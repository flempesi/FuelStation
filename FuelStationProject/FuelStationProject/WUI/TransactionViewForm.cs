﻿using FuelStationProject.Controllers;
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

        private void TransactionViewForm_Load(object sender, EventArgs e)
        {
            RefreshTransactionsGrid();
        }

        private void RefreshTransactionsGrid()
        {
            DataSet _MasterData = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter(Resources.SelectTransactionTable, DBController._SqlConnection);
            int response = adapter.Fill(_MasterData);


            ctrlTransactions.DataSource = _MasterData.Tables[0];
            ctrlTransactions.Refresh();
        }


        private void ctrlTransactionsView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            string cellValue = Convert.ToString(ctrlTransactionsView.GetFocusedRowCellValue("ID"));

            DataSet _Data = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter(string.Format("SELECT * FROM [TransactionLine]  WHERE [TransactionID]='{0}'", cellValue), DBController._SqlConnection);
            int response = adapter.Fill(_Data);


            ctrlTransactionLines.DataSource = _Data.Tables[0];
            ctrlTransactionLines.Refresh();

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshTransactionsGrid();
        }
    }
}
