﻿using FuelStationProject.Controllers;
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
    public partial class CustomerViewForm : DevExpress.XtraEditors.XtraForm {

        public CustomerController newcc { get; set; }
        public DatabaseConnectionController DBController { get; set; }

        //public SqlConnection NewSqlConnection;
        private DataSet _MasterData;



        public CustomerViewForm() {
            InitializeComponent();
        }

        #region Form Events

        private void CustomerViewForm_Load(object sender, EventArgs e) {
            RefreshGrid();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            RefreshGrid();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {

            CustomerForm customerForm = new CustomerForm();


        }

        #endregion



        private void RefreshGrid() {
            //CustomerController cc = new CustomerController();

            //newcc.GetCustomers(gridControl1, NewSqlConnection);

            _MasterData = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [Customer]", DBController._SqlConnection);
            int response = adapter.Fill(_MasterData);


            gridControl1.DataSource = _MasterData.Tables[0];
            //gridControl1.DataMember = _MasterData.Tables[0].TableName;
            gridControl1.Refresh();

            //gridView1.OptionsView.ShowGroupPanel = false;
        }

        private void btnDeleteCustomerFromGrid_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this entry ?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK) {


                SqlCommand command = new SqlCommand(string.Format("DELETE FROM [CUSTOMER] WHERE ID={0}", gridView1.GetFocusedRow()), DBController._SqlConnection);

                int rowsAffected = command.ExecuteNonQuery();



            }
            else {
             
            }
        }
    }
}
