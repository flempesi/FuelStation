using FuelStationProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStationProject.WUI {
    public partial class MDIMainForm : DevExpress.XtraBars.Ribbon.RibbonForm {

        private SqlConnection _SqlConnection;
        private DataSet _MasterData = new DataSet();

        public MDIMainForm() {
            InitializeComponent();
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Application.Exit();
        }

        private void MDIMainForm_Load(object sender, EventArgs e) {
            SqlConnect();
            InsertEmployee();


        }



        private void SqlConnect() {
            string connectionString = @"Server=localhost\SQLEXPRESS;Database=FuelStation;Trusted_Connection=True;";

            _SqlConnection = new SqlConnection(connectionString);
            _SqlConnection.Open();

            // log
            AppendLog("Connenction State", _SqlConnection.State);
        }

        private void DeleteTrans() {

            // DELETE, UPDATE, INSERT
           // SqlCommand command = new SqlCommand(Resources.DeleteTrans, _SqlConnection);
           // int rowsAffected = command.ExecuteNonQuery();


            //


            // log
            //AppendLog("Rows Affected", _SqlConnection.State);


        }

        private void ViewData() {

            // Standard Grid
            //ctrlGrid.AutoGenerateColumns = false;
            //ctrlGrid.DataSource = _MasterData;
            //ctrlGrid.DataMember = _MasterData.Tables[0].TableName;
            //ctrlGrid.Refresh();

            //foreach (DataRow row in _MasterData.Tables[0].Rows) {
            //    //AppendLog("Row", string.Format("{0} \t {1} \t {2} \t {3}", row[0], row[1], row[2], row[3]));

            //    AppendLog("Row", string.Format("{0} \t {1} \t ", row["Name"], row["TransactionDate"]));
            //}


            // Dev Express Grid
           
            //gridControl1.Refresh();


            //gridView1.OptionsView.ShowGroupPanel = false;
            //gridEmployee.DataSource = _MasterData.Tables[0];
            //gridControl1.DataMember = _MasterData.Tables[0].TableName;



        }

        private void InsertEmployee() {

            // INSERT todo insert parameters...
            SqlCommand command = new SqlCommand(Resources.InsertEmployee, _SqlConnection);
            int rowsAffected = command.ExecuteNonQuery();


            AppendLog("Rows Affected", _SqlConnection.State);


        }

        private void GetData() {

            try {

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT [Name], [Surname], [DateStart],[DateEnd],[Salary] FROM  Employee", _SqlConnection);
                adapter.Fill(_MasterData);

                // log
                AppendLog("Data Set Filled", "OK");
            }
            catch (Exception ex) {
                AppendLog("Exception", ex.Message);
            }
        }
        private void AppendLog(string name, object message) {
           // txtLog.AppendText(string.Format("{0}={1}{2}", name, message, Environment.NewLine));
        }
        private void ribbonControl1_Click(object sender, EventArgs e) {

        }

        private void btnViewEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            GetData();
            EmployeeViewForm form = new EmployeeViewForm();
            form.ViewData = _MasterData;
            form.Show();
        }
    }
}
