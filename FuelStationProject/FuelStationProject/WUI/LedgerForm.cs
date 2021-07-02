﻿using FuelStationProject.Controllers;
using FuelStationProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStationProject.WUI {
    public partial class LedgerForm : DevExpress.XtraEditors.XtraForm {

        public DatabaseConnectionController DBController { get; set; }
        private const decimal rentPerDay = 166.66m;


        public LedgerForm() {
            InitializeComponent();
        }
        private void LedgerForm_Load(object sender, EventArgs e) {

         
        }
        private void btnSearchLedger_Click(object sender, EventArgs e) {
            SearchLedger();

        }

        private void SearchLedger() {
            DateTime dateFrom = Convert.ToDateTime(dateEdit1.EditValue);
            DateTime dateToOld = Convert.ToDateTime(dateEdit2.EditValue);


            //modify DateTo so that its time is set to 23:59:59 in order to be calculated as a whole day
            DateTime dateTo = new DateTime(dateToOld.Year, dateToOld.Month, dateToOld.Day, 23, 59, 59);

            if ((dateTo - dateFrom).TotalDays < 0) {
                MessageBox.Show("Date from must be earlier than Date to.");
                return;
            }

            DataSet _MasterData = new DataSet();
            SelectEmployees(_MasterData);
            decimal totalSalaries = 0m;

            decimal totalRent = Convert.ToDecimal((dateTo - dateFrom).TotalDays) * rentPerDay;

            totalSalaries = CalculateSalariesCost(dateFrom, dateTo, _MasterData, totalSalaries);

            _MasterData.Clear();
            SelectFromTransactionTable(dateFrom, dateTo, _MasterData);
            decimal totalValue;
            decimal totalCost;


            //if the database has no transactions stored then is going to return null for TotalValue and TotalCost
            if (!DBNull.Value.Equals(_MasterData.Tables[0].Rows[0]["TotalValue"]) || !DBNull.Value.Equals(_MasterData.Tables[0].Rows[0]["TotalCost"])) {
                //not null
                totalValue = Convert.ToDecimal(_MasterData.Tables[0].Rows[0]["TotalValue"]);
                totalCost = Convert.ToDecimal(_MasterData.Tables[0].Rows[0]["TotalCost"]);
            }
            else {
                //null
                totalValue = 0m;
                totalCost = 0m;
            }

            PrintToForm(totalSalaries, totalRent, totalValue, totalCost);
        }

        private void PrintToForm(decimal totalSalaries, decimal totalRent, decimal totalValue, decimal totalCost) {
            ctrlIncome.EditValue = String.Format("{0} €", Convert.ToString(totalValue));
            ctrlProductCosts.EditValue = String.Format("{0} €", Convert.ToString(totalCost));

            ctrlSalaries.EditValue = String.Format("{0} €", Math.Round(totalSalaries, 2).ToString());
            ctrlRent.EditValue = String.Format("{0} €", Math.Round(totalRent, 2).ToString());

            ctrlExpences.EditValue = String.Format("{0} €", Math.Round((totalCost + Math.Round(totalSalaries, 2) + totalRent), 2).ToString());


            decimal expenses = totalCost + Math.Round(totalSalaries, 2) + totalRent;
            ProfitOrLoss(totalValue, expenses);
        }

        private void SelectEmployees(DataSet _MasterData) {
            try {
                SqlDataAdapter adapter = new SqlDataAdapter(Resources.SelectEmployeeTable, DBController._SqlConnection);
                int response = adapter.Fill(_MasterData);
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private static decimal CalculateSalariesCost(DateTime dateFrom, DateTime dateTo, DataSet _MasterData, decimal totalSalaries) {
            for (int i = 0; i < _MasterData.Tables[0].Rows.Count; i++) {
                DateTime dateStart = Convert.ToDateTime(_MasterData.Tables[0].Rows[i]["DateStart"]);
                DateTime dateEnd = Convert.ToDateTime(_MasterData.Tables[0].Rows[i]["DateEnd"]);

                decimal wage = (decimal)_MasterData.Tables[0].Rows[i]["Salary"] / 30;

                //DateTime DBnullDate = new DateTime(1900,1,1,0,0,0,0);

                //this is valid only if employee DateEnd is set to null, which means that the database interprets it as (1900-01-01 00:00:00:000)
                if (dateEnd < dateStart) {
                    dateEnd = dateTo;
                }
                if (dateStart > dateTo) {
                    continue;
                }

                else if (dateFrom <= dateStart && dateEnd <= dateTo) {
                    if (Convert.ToDecimal((dateEnd - dateStart).TotalDays)< 1m) {
                        totalSalaries += wage * 1;
                    }
                    else {
                        totalSalaries += wage * Convert.ToDecimal((dateEnd - dateStart).TotalDays);
                    }
                    
                }

                else if (dateStart < dateFrom && dateEnd > dateTo) {
                    totalSalaries += wage * Convert.ToDecimal((dateTo - dateFrom).TotalDays);
                }

                else if (dateStart < dateFrom && dateFrom < dateEnd) {
                    totalSalaries += wage * Convert.ToDecimal((dateEnd - dateFrom).TotalDays);
                }

                else if (dateStart < dateTo && dateTo < dateEnd) {
                    totalSalaries += wage * Convert.ToDecimal((dateTo - dateStart).TotalDays);
                }

            }

            return totalSalaries;
        }

        private void ProfitOrLoss(decimal totalValue, decimal expenses) {
            decimal profitOrLoss = totalValue - expenses;
            string result;

            if (profitOrLoss > 0m) {
                result = "Profit";

            }
            else if (profitOrLoss == 0m) {

                result = "Balance";

            }
            else {
                result = "Loss";
                profitOrLoss = expenses - totalValue;

            }

            ctrltotal.EditValue = String.Format("{0} : {1} € ", result, Math.Round(profitOrLoss, 2));
        }

        private void SelectFromTransactionTable(DateTime dateFrom, DateTime dateTo, DataSet _MasterData) {
            try {
                SqlDataAdapter adapter = new SqlDataAdapter(string.Format(Resources.QueryTransactionTable, dateFrom.ToString(), dateTo.ToString()), DBController._SqlConnection);
                int response = adapter.Fill(_MasterData);
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }


    }
}
