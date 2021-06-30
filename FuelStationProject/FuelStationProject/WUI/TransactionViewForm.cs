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
    public partial class TransactionViewForm : DevExpress.XtraEditors.XtraForm {


        public DatabaseConnectionController DBController { get; set; }

        public TransactionViewForm() {
            InitializeComponent();
        }

        private void TransactionViewForm_Load(object sender, EventArgs e) {
            RefreshTransactionsGrid();
        }
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            RefreshTransactionsGrid();

        }
        private void btnDeleteTransaction_Click(object sender, EventArgs e) {
            DeleteTransactionWithTransactionLines();

        }
        private void ctrlTransactionsView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            ShowTransactionLines();

        }

        private void RefreshTransactionsGrid() {
            gridTransactionLines.Refresh();
            ctrlTransactionsView.ClearSelection();

            DataSet _MasterData = new DataSet();
            _MasterData.Clear();
            try {
                SqlDataAdapter adapter = new SqlDataAdapter(Resources.SelectTransactionView, DBController._SqlConnection);
                int response = adapter.Fill(_MasterData);
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            ctrlTransactions.DataSource = _MasterData.Tables[0];
            ctrlTransactions.Refresh();

        }

        private void RefreshTransactionLinesGrid(string TransactionID) {

            gridViewTransactionLines.OptionsView.ShowGroupPanel = false;
            DataSet _MasterData = new DataSet();
            _MasterData.Clear();
            try {
                SqlDataAdapter adapter = new SqlDataAdapter(string.Format(Resources.SelectTransactionLineViewByID, TransactionID), DBController._SqlConnection);
                int response = adapter.Fill(_MasterData);
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            gridTransactionLines.DataSource = _MasterData.Tables[0];
            gridTransactionLines.Refresh();
        }

        private void ShowTransactionLines() {
            if (ctrlTransactionsView.RowCount > 0) {

                string transactionId = Convert.ToString(ctrlTransactionsView.GetFocusedRowCellValue("ID"));

                DataSet _Data = new DataSet();

                if (!string.IsNullOrEmpty(transactionId)) {
                    RefreshTransactionLinesGrid(transactionId);

                }

            }
        }

        private void DeleteTransactionWithTransactionLines() {
            gridTransactionLines.Refresh();


            DialogResult result = MessageBox.Show("Are you sure you want to delete this entry ?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK) {
                string transactionId = Convert.ToString(ctrlTransactionsView.GetRowCellValue(ctrlTransactionsView.FocusedRowHandle, "ID"));
                try {

                    SqlCommand command = new SqlCommand(string.Format(Resources.DeleteTransactionLineByTransactionID, transactionId), DBController._SqlConnection);
                    int rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception e) {
                    MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                try {
                    SqlCommand command = new SqlCommand(string.Format(Resources.DeleteTransaction, transactionId), DBController._SqlConnection);
                    int rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception e) {
                    MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                RefreshTransactionLinesGrid(transactionId);
                RefreshTransactionsGrid();

            }
        }

        private void repEditTransaction_Click(object sender, EventArgs e) {
            TransactionForm transactionForm = new TransactionForm();
            //transactionViewForm.MdiParent = this;
            transactionForm.DBController = DBController;
            transactionForm.TransactionID = Guid.Parse(Convert.ToString(ctrlTransactionsView.GetFocusedRowCellValue("ID")));
            transactionForm.Show();
            DataSet CustomerData = new DataSet();

            string cardNumber = Convert.ToString(ctrlTransactionsView.GetFocusedRowCellValue("CardNumber"));
            //try {
                SqlDataAdapter adapter = new SqlDataAdapter(string.Format(Resources.SelectCustomerByCardNumber, cardNumber), DBController._SqlConnection);
                int response = adapter.Fill(CustomerData);
            //}
            //catch (Exception e) {
            //    MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            //}
        }
    }
}
