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


        //public SqlConnection NewSqlConnection;
        private DataSet _MasterData;


        public TransactionForm() {
            InitializeComponent();
        }

        private void TransactionForm_Load(object sender, EventArgs e) {

         

            RefreshGrid();



        }


        private void RefreshGrid()
        {
            //CustomerController cc = new CustomerController();

            //newcc.GetCustomers(gridControl1, NewSqlConnection);

            _MasterData = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter(Resources.SelectItemTable, DBController._SqlConnection);
            int response = adapter.Fill(_MasterData);


            gridControl1.DataSource = _MasterData.Tables[0];
            //gridControl1.DataMember = _MasterData.Tables[0].TableName;
            gridControl1.Refresh();

            //gridView1.OptionsView.ShowGroupPanel = false;
        }

        //private void repQuantity_EditValueChanged(object sender, EventArgs e)
        //{

        //   decimal quantity =  Convert.ToDecimal(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Quantity"));

        //    decimal value = quantity * Convert.ToDecimal(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Item Price"));


        //    gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Value",value) ;

        //}

        private void repQuantity_ValueChanged(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Quantity"));

            decimal value = quantity * Convert.ToDecimal(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Price"));


            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "Value", value);

        }
    }
}
