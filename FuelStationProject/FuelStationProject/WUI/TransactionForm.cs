using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using FuelStationProject.Controllers;
using FuelStationProject.Impl;
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
    public partial class TransactionForm : DevExpress.XtraEditors.XtraForm {


        public DatabaseConnectionController DBController { get; set; }
        private DataSet _ViewData;
        public Guid TransactionID { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalCost { get; set; }
        public ItemTypeCategory Type { get; set; }
        public decimal DiscountValue { get; set; }
        public DataSet CustomerData { get; set; }

        bool _TransactionHasFuel;
        bool _TransactionOld;
        private DataSet _MasterData;


        public TransactionForm() {
            InitializeComponent();
        }

        private void TransactionForm_Load(object sender, EventArgs e) {
            TransactionFormLoad();

        }

        private void TransactionFormLoad() {
            if (TransactionID == Guid.Empty) {//for new transaction
                TransactionID = Guid.NewGuid();
            }
            else {
                //only for edit an existing transaction
                RefreshGridTransactionLines();
                _MasterData = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(string.Format(Resources.SelectTransactionByID, TransactionID), DBController._SqlConnection);
                int response = adapter.Fill(_MasterData);
                TotalPrice = Convert.ToDecimal(_MasterData.Tables[0].Rows[0]["TotalValue"]);
                TotalCost = Convert.ToDecimal(_MasterData.Tables[0].Rows[0]["TotalCost"]);
                DiscountValue = Convert.ToDecimal(_MasterData.Tables[0].Rows[0]["DiscountValue"]);
                ctrlTotalPrice.EditValue = String.Format("{0}  € ", TotalPrice);
                _TransactionOld = true;
            }

            RefreshGridItems();

            gridViewTransactionLines.OptionsView.ShowGroupPanel = false;

            ctrlCustomer.EditValue = string.Format("Name: {0} , Surname: {1}", CustomerData.Tables[0].Rows[0]["Name"].ToString(), CustomerData.Tables[0].Rows[0]["Surname"].ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            AddTransactionLineButtonCode();

        }
        private void btnOK_Click(object sender, EventArgs e) {
            SaveToDB();
        }


        private void repDeleteLine_Click(object sender, EventArgs e) {
            DeleteTransactionLine();
        }
        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }
        private void SaveToDB() {
            string customerID = CustomerData.Tables[0].Rows[0]["ID"].ToString();
            if (TotalPrice > 0) {
                if (_TransactionOld) {

                    
                    try {
                        SqlCommand command = new SqlCommand(string.Format(Resources.DeleteTransaction, TransactionID), DBController._SqlConnection);
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception e) {
                        MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }

                try {

                    SqlCommand command = new SqlCommand(string.Format(Resources.InsertTransaction, TransactionID, DateTime.Now, customerID, DiscountValue, TotalPrice, TotalCost), DBController._SqlConnection); ;
                    int rowsAffected = command.ExecuteNonQuery();


                }
                catch (Exception e) {
                    MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

                Close();
            }
            else {
                MessageBox.Show("Please, select an item to add in the transaction!");
            }
        }

        private void AddTransactionLineButtonCode() {
            if (gridViewItems.GetSelectedRows().Length == 1) {

                DataRow row = gridViewItems.GetDataRow(gridViewItems.GetSelectedRows()[0]);
                Guid itemId = Guid.Parse(Convert.ToString(row["ID"]));
                decimal quantity = Convert.ToDecimal(ctrlQuantity.EditValue);
                decimal price = Convert.ToDecimal(row["Price"]);
                decimal cost = Convert.ToDecimal(row["Cost"]);
                decimal value = price * quantity;
                string itemType = Convert.ToString(row["ItemType"]);

                if (_TransactionHasFuel && itemType == "Fuel") {
                    MessageBox.Show("You have already add Fuel.Only one FUEL type per Transaction");
                }
                else {
                    AddTransactionLine(itemId, quantity, price, cost, value, itemType);

                }

            }
        }

        private void AddTransactionLine(Guid itemId, decimal quantity, decimal price, decimal cost, decimal value, string itemType) {
            try {
                SqlCommand command = new SqlCommand(string.Format(Resources.InsertTransactionLine, TransactionID, itemId, quantity, price, value), DBController._SqlConnection);
                int rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            _ViewData = new DataSet();
            try {
                SqlDataAdapter adapter = new SqlDataAdapter(string.Format(Resources.SelectTransactionLineViewByID, TransactionID), DBController._SqlConnection);
                int response = adapter.Fill(_ViewData);
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            ctrlQuantity.EditValue = 1m;
            gridViewTransactionLines.OptionsView.ShowGroupPanel = false;
            gridTransactionLines.DataSource = _ViewData.Tables[0];

            gridTransactionLines.Refresh();

            if (itemType == "Fuel") {
                _TransactionHasFuel = true;
            }

            Calculations(quantity, cost, value, itemType);
        }

        private void Calculations(decimal quantity, decimal cost, decimal value, string itemType) {
            if (itemType == "Fuel" && value > 50) {
                Type = ItemTypeCategory.Fuel;

                TotalPrice = TotalPrice + value;
                DiscountValue = TotalPrice * (decimal)0.1;
                TotalPrice = TotalPrice - DiscountValue;

            }
            else {
                TotalPrice += value;
            }

            TotalCost += quantity * cost;
            ctrlTotalPrice.EditValue = String.Format("{0}  € ", TotalPrice);
        }

        public void RefreshGridTransactionLines() {
            _MasterData = new DataSet();
            try {
                SqlDataAdapter adapter = new SqlDataAdapter(string.Format(Resources.SelectTransactionLineViewByID, TransactionID), DBController._SqlConnection);
                int response = adapter.Fill(_MasterData);

                gridViewTransactionLines.OptionsView.ShowGroupPanel = false;
                gridTransactionLines.DataSource = _MasterData.Tables[0];
                gridTransactionLines.Refresh();
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }


        private void DeleteTransactionLine() {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this TrsansactionLiene ?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK) {

                decimal valueTransactionLine = Convert.ToDecimal(gridViewTransactionLines.GetRowCellValue(gridViewTransactionLines.FocusedRowHandle, "Value"));
                decimal quantity = Convert.ToDecimal(gridViewTransactionLines.GetRowCellValue(gridViewTransactionLines.FocusedRowHandle, "Quantity"));
                decimal costTransactionLine = Convert.ToDecimal(gridViewTransactionLines.GetRowCellValue(gridViewTransactionLines.FocusedRowHandle, "Cost")) * quantity;
                string itemType = Convert.ToString(gridViewTransactionLines.GetRowCellValue(gridViewTransactionLines.FocusedRowHandle, "ItemType"));
                try {
                    SqlCommand command = new SqlCommand(string.Format(Resources.DeleteTransactionLine, Convert.ToString(gridViewTransactionLines.GetRowCellValue(gridViewTransactionLines.FocusedRowHandle, "ID"))), DBController._SqlConnection);

                    int rowsAffected = command.ExecuteNonQuery();
                    RefreshGridTransactionLines();
                    TotalPrice -= valueTransactionLine;
                    ctrlTotalPrice.EditValue = String.Format("{0}  € ", TotalPrice);
                    TotalCost -= costTransactionLine;
                    if (itemType == "Fuel") {
                        _TransactionHasFuel = false;
                    }
                }
                catch (Exception e) {
                    MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }

            }
        }



        private void RefreshGridItems() {
            _MasterData = new DataSet();
            try {
                SqlDataAdapter adapter = new SqlDataAdapter(Resources.SelectItemTable, DBController._SqlConnection);
                int response = adapter.Fill(_MasterData);
                gridViewItems.OptionsView.ShowGroupPanel = false;
                gridItems.DataSource = _MasterData.Tables[0];
                gridItems.Refresh();
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }
    }
}
