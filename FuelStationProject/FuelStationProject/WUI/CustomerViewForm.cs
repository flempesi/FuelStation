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
    public partial class CustomerViewForm : DevExpress.XtraEditors.XtraForm
    {

        public CustomerController newcc { get; set; }
        public DatabaseConnectionController DBController { get; set; }

        //public SqlConnection NewSqlConnection;
        private DataSet _MasterData;



        public CustomerViewForm()
        {
            InitializeComponent();
        }

        #region Form Events

        private void CustomerViewForm_Load(object sender, EventArgs e)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            CultureInfo.CurrentUICulture = new CultureInfo("en-US", false);
            RefreshGrid();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshGrid();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            CustomerForm customerForm = new CustomerForm();


        }

        #endregion



        private void RefreshGrid()
        {
            //CustomerController cc = new CustomerController();

            //newcc.GetCustomers(gridControl1, NewSqlConnection);

            _MasterData = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter(Resources.SelectCustomerTable, DBController._SqlConnection);
            int response = adapter.Fill(_MasterData);


            gridControl1.DataSource = _MasterData.Tables[0];
            //gridControl1.DataMember = _MasterData.Tables[0].TableName;
            gridControl1.Refresh();

            //gridView1.OptionsView.ShowGroupPanel = false;
        }

        private void btnDeleteCustomerFromGrid_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this entry ?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {


                SqlCommand command = new SqlCommand(string.Format(Resources.DeleteCustomer, Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID"))), DBController._SqlConnection);

                int rowsAffected = command.ExecuteNonQuery();

                RefreshGrid();

            }
            else
            {

            }
        }

        private void btnSaveAfterEditingCustomerFromGrid_Click(object sender, EventArgs e)
        {

            string name = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Name"));
            string surname = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Surname"));
            string cardNumber = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CardNumber"));
            string id = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID"));



            DialogResult result = MessageBox.Show("Are you sure you want to save this entry ?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {

                if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(surname) && !string.IsNullOrWhiteSpace(cardNumber))
                {

                    SqlCommand command = new SqlCommand(string.Format(Resources.UpdateCustomer, name, surname, cardNumber, id), DBController._SqlConnection);

                    int rowsAffected = command.ExecuteNonQuery();


                    RefreshGrid();
                }
                else
                {

                    MessageBox.Show("All fields must be filled.");
                    RefreshGrid();
                }


            }
            else
            {

            }
        }
    }
}
