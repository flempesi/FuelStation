﻿using DevExpress.XtraGrid.Views.Grid;
using FuelStationProject.Controllers;
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
    public partial class EmployeeViewForm : DevExpress.XtraEditors.XtraForm {
        DataSet _MasterData { get; set; }
        DataSet _MasterDataOld { get; set; }
        public DatabaseConnectionController DBController { get; set; }

        private DateTime _DateEditNullDate = new DateTime(1, 1, 1, 0, 0, 0, 0);


        public EmployeeViewForm() {
            InitializeComponent();
        }

        private void EmployeeViewForm_Load(object sender, EventArgs e) {
            gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;


            RefreshEmployeeGrid();
        }
        private void repSaveButtonEdit_Click(object sender, EventArgs e) {
            SaveButtonCode();

        }

        private void repdeleteButtonEdit_Click(object sender, EventArgs e) {
            DeletebuttonCode();

        }

        private void SaveButtonCode() {
            DialogResult result = MessageBox.Show("Are you sure you want to Change this entry ?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK) {

                SaveEmployee();
                RefreshEmployeeGrid();

            }
        }

        private void DeletebuttonCode() {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this entry ?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK) {
                try {
                    SqlCommand command = new SqlCommand(string.Format(Resources.DeleteEmployee, Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID"))), DBController._SqlConnection);

                    int rowsAffected = command.ExecuteNonQuery();
                    RefreshEmployeeGrid();
                }
                catch (Exception e) {
                    MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void RefreshEmployeeGrid() {
            _MasterData = new DataSet();
            _MasterDataOld = new DataSet();
            try {
                SqlDataAdapter adapter = new SqlDataAdapter(Resources.SelectEmployeeTable, DBController._SqlConnection);
                int response = adapter.Fill(_MasterData);
                response = adapter.Fill(_MasterDataOld);
                //gridView1.OptionsView.ShowGroupPanel = false;
                gridEmployee.DataSource = _MasterData.Tables[0];
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        public void SaveEmployee() {







            string id = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID"));
            string name = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Name"));
            string surname = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Surname"));

            DateTime dateStart;

            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DateStart") == DBNull.Value) {

                MessageBox.Show("DateStart is required.");
                return;

            }
            else {

                dateStart = Convert.ToDateTime(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DateStart"));

            }
            DateTime dateEnd;

            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DateEnd") != DBNull.Value) {
                dateEnd = Convert.ToDateTime(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DateEnd"));

            }
            else {

                dateEnd = _DateEditNullDate;

            }
            //dateEnd = Convert.ToDateTime(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DateEnd"));


            decimal salary;

            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Salary") != DBNull.Value) {

                salary = Convert.ToDecimal(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Salary"));



            }
            else {

                salary = 0m;
            }
            //salary = Convert.ToDecimal(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Salary"));


            //DateTime dt = new DateTime(1, 1, 1, 0, 0, 0, 0);


            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(surname) && salary > 0m && dateStart != _DateEditNullDate) {
                //SaveToDB(id, name, surname, dateStart, dateEnd, salary);

                if (dateEnd == _DateEditNullDate) {
                    SaveToDB(id, name, surname, dateStart, dateEnd, salary);

                    Close();
                }
                else if (dateEnd >= dateStart) {
                    SaveToDB(id, name, surname, dateStart, dateEnd, salary);

                    Close();
                }

                else {

                    MessageBox.Show("DateStart must be earlier than DateEnd");
                }

            }
            else {

                MessageBox.Show("Please fill all fields with valid values!");
            }
        }

        private void SaveToDB(string id, string name, string surname, DateTime dateStart, DateTime dateEnd, decimal salary) {
            if (!string.IsNullOrWhiteSpace(id)) {//update

                if (dateEnd==_DateEditNullDate) {
                    try {
                        SqlCommand command = new SqlCommand(string.Format(Resources.UpdateEmployeeIfDateEndIsNull,name,surname,dateStart,salary, id), DBController._SqlConnection); 
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception e) {
                        MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }

                }
                else {


                    UpdateController updateController = new UpdateController();
                    string sql = updateController.UpdateEntry(id, "Employee", _MasterData, _MasterDataOld);

                    if (sql != String.Empty) {
                        try {
                            SqlCommand command = new SqlCommand(sql, DBController._SqlConnection); ;
                            int rowsAffected = command.ExecuteNonQuery();
                        }
                        catch (Exception e) {
                            MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                    }

                }


            }
            else {//insert
                try {
                    if (dateEnd == _DateEditNullDate) {//DateEnd null

                        SqlCommand command2 = new SqlCommand(string.Format(Resources.InsertEmployeeIfDateEndIsNull, name, surname, dateStart, salary), DBController._SqlConnection);
                        int rowsAffected2 = command2.ExecuteNonQuery();
                    }
                    else {//when DateEnd not null 

                        SqlCommand command = new SqlCommand(string.Format(Resources.InsertEmployee, name, surname, dateStart, dateEnd, salary), DBController._SqlConnection);
                        int rowsAffected = command.ExecuteNonQuery();


                    }
                }
                catch (Exception e) {
                    MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            RefreshEmployeeGrid();
        }

        private void gridEmployee_Click(object sender, EventArgs e) {

        }
    }
}
