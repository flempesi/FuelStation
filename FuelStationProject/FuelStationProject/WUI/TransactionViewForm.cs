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

namespace FuelStationProject.WUI
{
    public partial class TransactionViewForm : DevExpress.XtraEditors.XtraForm
    {


        public DatabaseConnectionController DBController { get; set; }

        public TransactionViewForm()
        {
            InitializeComponent();
        }

        private void TransactionViewForm_Load(object sender, EventArgs e)
        {
            RefreshTransactionsGrid();
        }

        private void RefreshTransactionsGrid()
        {
            ctrlTransactionLines.Refresh();
            ctrlTransactionsView.ClearSelection();


            DataSet _MasterData = new DataSet();
            _MasterData.Clear();

            SqlDataAdapter adapter = new SqlDataAdapter(Resources.SelectTransactionTable, DBController._SqlConnection);
            int response = adapter.Fill(_MasterData);


            ctrlTransactions.DataSource = _MasterData.Tables[0];
            ctrlTransactions.Refresh();

            

        }

        private void RefreshTransactionLinesGrid()
        {


            DataSet _MasterData = new DataSet();
            _MasterData.Clear();

            SqlDataAdapter adapter = new SqlDataAdapter("select * from [TransactionLine]", DBController._SqlConnection);
            int response = adapter.Fill(_MasterData);


            ctrlTransactionLines.DataSource = _MasterData.Tables[0];
            ctrlTransactionLines.Refresh();
        }



        private void ctrlTransactionsView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            if (ctrlTransactionsView.RowCount > 0)
            {



                string cellValue = Convert.ToString(ctrlTransactionsView.GetFocusedRowCellValue("ID"));

                DataSet _Data = new DataSet();

                if (!string.IsNullOrEmpty(cellValue))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(string.Format("SELECT * FROM [TransactionLine]  WHERE [TransactionID]='{0}'", cellValue), DBController._SqlConnection);
                    int response = adapter.Fill(_Data);

                }


                ctrlTransactionLines.DataSource = _Data.Tables[0];
                ctrlTransactionLines.Refresh();


                //RefreshTransactionsGrid();
            }
            // RefreshTransactionsGrid();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshTransactionsGrid();
            //RefreshTransactionLinesGrid();

        }

        private void btnDeleteTransaction_Click(object sender, EventArgs e)
        {

            ctrlTransactionLines.Refresh();


            DialogResult result = MessageBox.Show("Are you sure you want to delete this entry ?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {


                SqlCommand command = new SqlCommand(string.Format("DELETE FROM [dbo].[TransactionLine] WHERE [TransactionID]='{0}'", Convert.ToString(ctrlTransactionsView.GetRowCellValue(ctrlTransactionsView.FocusedRowHandle, "ID"))), DBController._SqlConnection);
                int rowsAffected = command.ExecuteNonQuery();


                command = new SqlCommand(string.Format("DELETE FROM [dbo].[Transaction] WHERE [ID]='{0}'", Convert.ToString(ctrlTransactionsView.GetRowCellValue(ctrlTransactionsView.FocusedRowHandle, "ID"))), DBController._SqlConnection);
                rowsAffected = command.ExecuteNonQuery();


                RefreshTransactionLinesGrid();
                RefreshTransactionsGrid();

            }
            else
            {

            }
        }
    }
}
