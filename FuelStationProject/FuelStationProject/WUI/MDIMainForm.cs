using FuelStationProject.Controllers;
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

        private DataSet _MasterData = new DataSet();

        private DatabaseConnectionController _DBConnection;


        public MDIMainForm() {
            InitializeComponent();
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Application.Exit();
        }

        private void MDIMainForm_Load(object sender, EventArgs e) {

            _DBConnection = new DatabaseConnectionController();

            _DBConnection.Connection();
        
        }


        //private void AppendLog(string name, object message) {
            // txtLog.AppendText(string.Format("{0}={1}{2}", name, message, Environment.NewLine));
        //}
        private void ribbonControl1_Click(object sender, EventArgs e) {

        }


        private void btnViewEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            EmployeeViewForm form = new EmployeeViewForm();
            form.ViewData = _MasterData;
            form.MdiParent = this;
            form.DBController = _DBConnection;
            form.Show();
        }

        private void btnViewCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

            CustomerViewForm customerViewForm = new CustomerViewForm();
            customerViewForm.MdiParent = this;
            customerViewForm.DBController = _DBConnection;
            customerViewForm.Show();

        }

        private void btnAddCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

            CustomerForm customerForm = new CustomerForm();
            customerForm.MdiParent = this;
            customerForm.DBController = _DBConnection;
            customerForm.Show();

        }

        private void btnAddEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.MdiParent = this;
            employeeForm.DBController = _DBConnection;
            employeeForm.Show();
        }
    }
}
