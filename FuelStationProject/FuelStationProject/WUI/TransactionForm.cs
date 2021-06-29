using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
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
//using DevExpress.XtraEditors.Repository;

namespace FuelStationProject.WUI {
    public partial class TransactionForm : DevExpress.XtraEditors.XtraForm {


        public DatabaseConnectionController DBController { get; set; }
        public DataSet ViewData { get; set; }
        public Guid TransactionID { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalCost { get; set; }

        //public SqlConnection NewSqlConnection;
        private DataSet _MasterData;


        public TransactionForm() {
            InitializeComponent();
        }

        private void TransactionForm_Load(object sender, EventArgs e) {
            //gridItems.

            TransactionID = Guid.NewGuid();
            RefreshGridItems();

            gridView1.OptionsView.ShowGroupPanel = false;

        }


        private void RefreshGridItems()
        {
            

            _MasterData = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter(Resources.SelectItemTable, DBController._SqlConnection);
            int response = adapter.Fill(_MasterData);

            gridView2.OptionsView.ShowGroupPanel = false;
            gridItems.DataSource = _MasterData.Tables[0];
            //gridControl1.DataMember = _MasterData.Tables[0].TableName;
            gridItems.Refresh();

            //gridView1.OptionsView.ShowGroupPanel = false;
        }

      

        private void repQuantity_ValueChanged(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Quantity"));

            decimal value = quantity * Convert.ToDecimal(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Price"));


            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Value", value);

        }

        private void btnAdd_Click(object sender, EventArgs e) {
            
            if (gridView2.GetSelectedRows().Length == 1) {

                DataRow row =gridView2.GetDataRow(gridView2.GetSelectedRows()[0]);
                Guid itemId = Guid.Parse(Convert.ToString(row["ID"]));
                // string description
                decimal quantity = Convert.ToDecimal(ctrlQuantity.EditValue);
                decimal price = Convert.ToDecimal(row["Price"]);
                decimal cost = Convert.ToDecimal(row["Cost"]);
                decimal value = price * quantity;


                SqlCommand command = new SqlCommand(string.Format(Resources.InsertTransactionLine, TransactionID,itemId, quantity, price,value), DBController._SqlConnection);
                int rowsAffected = command.ExecuteNonQuery();

                ViewData = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(string.Format(Resources.SelectTransactionLineByID,TransactionID), DBController._SqlConnection);
                int response = adapter.Fill(ViewData);

                gridView1.OptionsView.ShowGroupPanel = false;
                gridTransactionLines.DataSource = ViewData.Tables[0];
               
                gridTransactionLines.Refresh();

                TotalPrice += value;
                TotalCost += quantity * cost;
                ctrlTotalPrice.EditValue = TotalPrice;


            }

           
            
        }

        private void btnOK_Click(object sender, EventArgs e) {

            //([ID],[Date],[CustomerID],[DiscountValue],[TotalValue],[TotalCost])
            decimal discountValue = 0m;
            SqlCommand command = new SqlCommand(string.Format(Resources.InsertTransaction, TransactionID, DateTime.Now, Guid.NewGuid(), discountValue, TotalPrice, TotalCost), DBController._SqlConnection); ;
            int rowsAffected = command.ExecuteNonQuery();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataSet customerInfo = new DataSet();

            string cardNumber = Convert.ToString(ctrlCardNumber.EditValue);

            SqlDataAdapter adapter = new SqlDataAdapter(string.Format("Select [Name], [Surname], [CardNumber] from [Customer] where [CardNumber]='{0}'", cardNumber), DBController._SqlConnection);
            int response = adapter.Fill(customerInfo);

            lblCustomerInfo.Text = customerInfo.Tables[0].Rows[0]["Name"].ToString();
        }
    }
}
