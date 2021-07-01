using DevExpress.XtraGrid.Views.Grid;
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
    public partial class CustomerViewForm : DevExpress.XtraEditors.XtraForm {
        public DatabaseConnectionController DBController { get; set; }

        private DataSet _MasterDataOld;
        private DataSet _MasterData;

        public CustomerViewForm() {
            InitializeComponent();
        }

        private void CustomerViewForm_Load(object sender, EventArgs e) {
            CustomersViewLoad();

        }


        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            RefreshGridCustomers();
        }
        private void btnSaveCustomerFromGrid_Click(object sender, EventArgs e) {
            SaveCustomer();
        }
        private void btnDeleteCustomerFromGrid_Click(object sender, EventArgs e) {
            DeleteCustomer();

        }



        private void CustomersViewLoad() {
            gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
            gridView1.OptionsView.ShowGroupPanel = false;
            //CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            //CultureInfo.CurrentUICulture = new CultureInfo("en-US", false);
            RefreshGridCustomers();
        }



        //fill two Datasets(old data and new data) with all the info of Customer table
        private void RefreshGridCustomers() {
            _MasterData = new DataSet();
            _MasterDataOld = new DataSet();
            try {
                SqlDataAdapter adapter = new SqlDataAdapter(Resources.SelectCustomerTable, DBController._SqlConnection);
                int response = adapter.Fill(_MasterData);
                response = adapter.Fill(_MasterDataOld);
                gridControl1.DataSource = _MasterData.Tables[0];
                gridControl1.Refresh();
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }



        //delete customer by clicking on the specific row delete icon
        private void DeleteCustomer() {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this entry ?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK) {
                try {
                    SqlCommand command = new SqlCommand(string.Format(Resources.DeleteCustomer, Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID"))), DBController._SqlConnection);

                    int rowsAffected = command.ExecuteNonQuery();

                    RefreshGridCustomers();

                }
                catch (Exception e) {
                    MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

            }
        }


        private void SaveCustomer() {
            string name = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Name"));
            string surname = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Surname"));
            string cardNumber = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CardNumber"));
            string id = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID"));



            DialogResult result = MessageBox.Show("Are you sure you want to save this entry ?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK) {

                if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(surname) && !string.IsNullOrWhiteSpace(cardNumber)) {
                    SaveToDB(name, surname, cardNumber, id);

                    RefreshGridCustomers();
                }
                else {

                    MessageBox.Show("All fields must be filled.");
                    RefreshGridCustomers();
                }

            }
        }


        //update only the columns that have been changed, in each row
        private void SaveToDB(string name, string surname, string cardNumber, string id) {
            if (!string.IsNullOrWhiteSpace(id)) {
                UpdateController updateController = new UpdateController();
                string sql = updateController.UpdateEntry(id, "Customer", _MasterData, _MasterDataOld);

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
            else {
                try {
                    SqlCommand command = new SqlCommand(string.Format(Resources.InsertCustomer, name, surname, cardNumber), DBController._SqlConnection);

                    int rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception e) {
                    MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }

        }

    }
}