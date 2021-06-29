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
    public partial class MDIMainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        private DataSet _MasterData = new DataSet();

        private DatabaseConnectionController _DBConnection;


        public MDIMainForm()
        {
            InitializeComponent();
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _DBConnection._SqlConnection.Close();
            Application.Exit();
        }

        private void MDIMainForm_Load(object sender, EventArgs e)
        {

            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            CultureInfo.CurrentUICulture = new CultureInfo("en-US", false);

            _DBConnection = new DatabaseConnectionController();

            _DBConnection.Connection();

        }


        //private void AppendLog(string name, object message) {
        // txtLog.AppendText(string.Format("{0}={1}{2}", name, message, Environment.NewLine));
        //}
        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }


        private void btnViewEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EmployeeViewForm employeeViewform = new EmployeeViewForm();
            employeeViewform.ViewData = _MasterData;
            employeeViewform.MdiParent = this;
            employeeViewform.DBController = _DBConnection;
            employeeViewform.Show();
        }

        private void btnViewCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            CustomerViewForm customerViewForm = new CustomerViewForm();
            customerViewForm.MdiParent = this;
            customerViewForm.DBController = _DBConnection;
            customerViewForm.Show();

        }

        private void btnAddCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            CustomerForm customerForm = new CustomerForm();
            customerForm.MdiParent = this;
            customerForm.DBController = _DBConnection;
            customerForm.Show();

        }

        private void btnAddEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.MdiParent = this;
            employeeForm.DBController = _DBConnection;
            employeeForm.Show();
        }

        private void btnAddItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ItemForm itemForm = new ItemForm();
            itemForm.MdiParent = this;
            itemForm.DBController = _DBConnection;
            itemForm.Show();
        }

        private void btnViewItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ItemViewForm itemViewForm = new ItemViewForm();
            itemViewForm.ViewData = _MasterData;
            itemViewForm.MdiParent = this;
            itemViewForm.DBController = _DBConnection;
            itemViewForm.Show();
        }

        private void btnAddTransaction_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm();
            //transactionForm.ViewData = _MasterData;
            transactionForm.MdiParent = this;
            transactionForm.DBController = _DBConnection;
            transactionForm.Show();
        }

        private void btnViewTransaction_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TransactionViewForm transactionViewForm = new TransactionViewForm();
            //transactionForm.ViewData = _MasterData;
            transactionViewForm.MdiParent = this;
            transactionViewForm.DBController = _DBConnection;
            transactionViewForm.Show();
        }

        private void btnViewLedger_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LedgerForm ledgerForm = new LedgerForm();
            //transactionForm.ViewData = _MasterData;
            ledgerForm.MdiParent = this;
            ledgerForm.DBController = _DBConnection;
            ledgerForm.Show();
        }
    }
}
