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

namespace FuelStationProject.WUI
{
    public partial class LedgerForm : DevExpress.XtraEditors.XtraForm
    {

        public DatabaseConnectionController DBController { get; set; }
        private const decimal rentPerDay = 166.66m;


        public LedgerForm()
        {
            InitializeComponent();
        }

        private void btnSearchLedger_Click(object sender, EventArgs e)
        {


            DateTime dateFrom = Convert.ToDateTime(dateEdit1.EditValue);
            DateTime dateTo = Convert.ToDateTime(dateEdit2.EditValue);

            if ((dateTo - dateFrom).TotalDays < 0)
            {
                MessageBox.Show("Date from must be earlier than Date to.");
                return;
            }

            DataSet _MasterData = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter(Resources.SelectEmployeeTable, DBController._SqlConnection);
            int response = adapter.Fill(_MasterData);

            decimal totalSalaries = 0m;

            decimal totalRent = Convert.ToDecimal((dateTo - dateFrom).TotalDays) * rentPerDay;



            for (int i = 0; i < _MasterData.Tables[0].Rows.Count; i++)
            {
                DateTime dateStart = Convert.ToDateTime(_MasterData.Tables[0].Rows[i]["DateStart"]);
                DateTime dateEnd = Convert.ToDateTime(_MasterData.Tables[0].Rows[i]["DateEnd"]);

                decimal wage = (decimal)_MasterData.Tables[0].Rows[i]["Salary"] / 30;





                if (dateFrom <= dateStart && dateEnd <= dateTo)
                {
                    totalSalaries = totalSalaries + wage * Convert.ToDecimal((dateEnd - dateStart).TotalDays);
                }

                else if (dateStart < dateFrom && dateEnd > dateTo)
                {
                    totalSalaries = totalSalaries + wage * Convert.ToDecimal((dateTo - dateFrom).TotalDays);
                }

                else if (dateStart < dateFrom && dateFrom < dateEnd)
                {
                    totalSalaries = totalSalaries + wage * Convert.ToDecimal((dateEnd - dateFrom).TotalDays);
                }

                else if (dateStart < dateTo && dateTo < dateEnd)
                {
                    totalSalaries = totalSalaries + wage * Convert.ToDecimal((dateTo - dateStart).TotalDays);
                }

            }

            _MasterData.Clear();
            adapter = new SqlDataAdapter(string.Format("select sum([TotalValue]) as 'TotalValue', sum([TotalCost]) as 'TotalCost' from [Transaction] WHERE [Date] BETWEEN '{0}'  AND  '{1}' ", dateFrom.ToString(), dateTo.ToString()), DBController._SqlConnection);
            response = adapter.Fill(_MasterData);

            decimal totalValue ;
            decimal totalCost ;

            if (!DBNull.Value.Equals(_MasterData.Tables[0].Rows[0]["TotalValue"]) || !DBNull.Value.Equals(_MasterData.Tables[0].Rows[0]["TotalCost"]))
            {
                //not null

                totalValue = Convert.ToDecimal(_MasterData.Tables[0].Rows[0]["TotalValue"]);

                totalCost = Convert.ToDecimal(_MasterData.Tables[0].Rows[0]["TotalCost"]);

            }
            else
            {
                //null


                totalValue = 0m;

                totalCost = 0m;

            }





            lblRevenue.Text = Convert.ToString(totalValue);
            lblProductsCosts.Text = Convert.ToString(totalCost);




            lblEmployeesSalary.Text = Math.Round(totalSalaries, 2).ToString();
            lblRent.Text = totalRent.ToString();

            lblExpenses.Text = (totalCost + Math.Round(totalSalaries, 2) + totalRent).ToString();



            decimal expenses = totalCost + Math.Round(totalSalaries, 2) + totalRent;
            decimal profitOrLoss = totalValue - expenses;


            if (profitOrLoss > 0m)
            {
                lblProfitOrLossTitle.Text = "Profit";

            }
            else if (profitOrLoss == 0m)
            {

                lblProfitOrLossTitle.Text = "Balance";

            }
            else
            {
                lblProfitOrLossTitle.Text = "Loss";

            }


            lblProfitOrLoss.Text = profitOrLoss.ToString();


        }

        private void LedgerForm_Load(object sender, EventArgs e)
        {

            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            CultureInfo.CurrentUICulture = new CultureInfo("en-US", false);
        }
    }
}
