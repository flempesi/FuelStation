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
//using DevExpress.XtraEditors.Repository;

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

        //bool TransactionHasFuel;
        bool _TransactionHasFuel;
        bool _CustomerFound;

        //public SqlConnection NewSqlConnection;
        private DataSet _MasterData;


        public TransactionForm() {
            InitializeComponent();
        }

        private void TransactionForm_Load(object sender, EventArgs e) {
            //gridItems.

            TransactionID = Guid.NewGuid();
            RefreshGridItems();

            gridViewTransactionLines.OptionsView.ShowGroupPanel = false;

            ctrlCustomer.EditValue = string.Format("Name: {0} , Surname: {1}", CustomerData.Tables[0].Rows[0]["Name"].ToString(), CustomerData.Tables[0].Rows[0]["Surname"].ToString());

        }


        private void RefreshGridItems()
        {
            

            _MasterData = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter(Resources.SelectItemTable, DBController._SqlConnection);
            int response = adapter.Fill(_MasterData);

            gridViewItems.OptionsView.ShowGroupPanel = false;
            gridItems.DataSource = _MasterData.Tables[0];
            //gridControl1.DataMember = _MasterData.Tables[0].TableName;
            gridItems.Refresh();

            //gridView1.OptionsView.ShowGroupPanel = false;
        }

      

        private void repQuantity_ValueChanged(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(gridViewTransactionLines.GetRowCellValue(gridViewTransactionLines.FocusedRowHandle, "Quantity"));

            decimal value = quantity * Convert.ToDecimal(gridViewTransactionLines.GetRowCellValue(gridViewTransactionLines.FocusedRowHandle, "Price"));


            gridViewTransactionLines.SetRowCellValue(gridViewTransactionLines.FocusedRowHandle, "Value", value);

        }

        private void btnAdd_Click(object sender, EventArgs e) {
            
            if (gridViewItems.GetSelectedRows().Length == 1) {

                DataRow row =gridViewItems.GetDataRow(gridViewItems.GetSelectedRows()[0]);
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

                    SqlCommand command = new SqlCommand(string.Format(Resources.InsertTransactionLine, TransactionID, itemId, quantity, price, value), DBController._SqlConnection);
                    int rowsAffected = command.ExecuteNonQuery();

                    _ViewData = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(string.Format(Resources.SelectTransactionLineViewByID, TransactionID), DBController._SqlConnection);
                    int response = adapter.Fill(_ViewData);

                    gridViewTransactionLines.OptionsView.ShowGroupPanel = false;
                    gridTransactionLines.DataSource = _ViewData.Tables[0];

                    gridTransactionLines.Refresh();

                    if (itemType == "Fuel") {
                        _TransactionHasFuel = true;
                    }

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
                    ctrlTotalPrice.EditValue = TotalPrice;



                }
   

            }

           
            
        }

        private void btnOK_Click(object sender, EventArgs e) {
            SqlCommand command = new SqlCommand(string.Format(Resources.InsertTransaction, TransactionID, DateTime.Now, Guid.NewGuid(), DiscountValue, TotalPrice, TotalCost), DBController._SqlConnection); ;
            int rowsAffected = command.ExecuteNonQuery();
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            //DataSet customerInfo = new DataSet();

            //string cardNumber = Convert.ToString(ctrlCardNumber.EditValue);

            //SqlDataAdapter adapter = new SqlDataAdapter(string.Format("Select [Name], [Surname], [CardNumber] from [Customer] where [CardNumber]='{0}'", cardNumber), DBController._SqlConnection);
            //int response = adapter.Fill(customerInfo);
            //if (response == 1) {
            //    _CustomerFound = true;
            //    ctrlCustomer.EditValue = string.Format("Name: {0} , Surname: {1}", customerInfo.Tables[0].Rows[0]["Name"].ToString(), customerInfo.Tables[0].Rows[0]["Surname"].ToString());
            //}
            //else {
            //    MessageBox.Show("Customer Not Found!Please try again!");
            //}
        }

        private void gridTransactionLines_Click(object sender, EventArgs e) {

        }


        public void RefreshGridTransactionLines() {
            _MasterData = new DataSet();
            //try
            SqlDataAdapter adapter = new SqlDataAdapter(string.Format(Resources.SelectTransactionLineViewByID, TransactionID), DBController._SqlConnection);
            int response = adapter.Fill(_MasterData);

            gridViewTransactionLines.OptionsView.ShowGroupPanel = false;
            gridTransactionLines.DataSource = _MasterData.Tables[0];
            //gridControl1.DataMember = _MasterData.Tables[0].TableName;
            gridTransactionLines.Refresh();

        }

        private void repDeleteLine_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this TrsansactionLiene ?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK) {
                //SqlCommand command = new SqlCommand(string.Format(Resources.DeleteEmployee, Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID"))), DBController._SqlConnection);
                decimal valueTransactionLine = Convert.ToDecimal(gridViewTransactionLines.GetRowCellValue(gridViewTransactionLines.FocusedRowHandle, "Value"));
                decimal quantity = Convert.ToDecimal(gridViewTransactionLines.GetRowCellValue(gridViewTransactionLines.FocusedRowHandle, "Quantity"));
                decimal costTransactionLine = Convert.ToDecimal(gridViewTransactionLines.GetRowCellValue(gridViewTransactionLines.FocusedRowHandle, "Cost")) * quantity;
                SqlCommand command = new SqlCommand(string.Format(Resources.DeleteTransactionLine, Convert.ToString(gridViewTransactionLines.GetRowCellValue(gridViewTransactionLines.FocusedRowHandle, "ID"))), DBController._SqlConnection);
                
                int rowsAffected = command.ExecuteNonQuery();
                RefreshGridTransactionLines();
                TotalPrice -= valueTransactionLine;
                ctrlTotalPrice.EditValue = TotalPrice;
                TotalCost -= costTransactionLine;            }
        }

        private void lblCustomerInfo_Click(object sender, EventArgs e) {

        }
    }
}
