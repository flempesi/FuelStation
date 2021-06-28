using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStationProject.WUI
{
    public partial class ItemViewForm : DevExpress.XtraEditors.XtraForm
    {
        public DataSet ViewData { get; set; }

        public DatabaseConnectionController DBController { get; set; }

        public ItemViewForm()
        {
            InitializeComponent();
        }


        private void ItemViewForm_Load(object sender, EventArgs e)
        {

            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            CultureInfo.CurrentUICulture = new CultureInfo("en-US", false);

            RefreshItemGrid();
            foreach (ItemTypeCategory type in Enum.GetValues(typeof(ItemTypeCategory)))
            {
                cmbItemType.Items.Add(type);
            }

        }


        private void repSaveButtonEdit_Click(object sender, EventArgs e)
        {
            SaveButtonCode();

        }

        private void repdeleteButtonEdit_Click(object sender, EventArgs e)
        {
            DeletebuttonCode();

        }
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshItemGrid();
        }



        private void SaveButtonCode()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Change this entry ?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {

                UpdateItem();
                RefreshItemGrid();

            }
        }


        private void DeletebuttonCode()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this entry ?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {


                SqlCommand command = new SqlCommand(string.Format(Resources.DeleteItem, Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID"))), DBController._SqlConnection);

                int rowsAffected = command.ExecuteNonQuery();
                RefreshItemGrid();

            }
        }

        private void RefreshItemGrid()
        {
            ViewData = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(Resources.SelectItemTable, DBController._SqlConnection);
            int response = adapter.Fill(ViewData);

            gridView1.OptionsView.ShowGroupPanel = false;
            gridItem.DataSource = ViewData.Tables[0];

        }

        public void UpdateItem()
        {
            Guid id = Guid.Parse(Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID")));
            string code = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Code"));
            string description = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Description"));
            string itemType = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ItemType"));

            decimal price, cost;

            if (!string.IsNullOrWhiteSpace(code) && !string.IsNullOrWhiteSpace(description) && !string.IsNullOrWhiteSpace(itemType)
                &&
                  decimal.TryParse(Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Price")), out price) && price > 0
                  && decimal.TryParse(Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Cost")), out cost) && cost > 0)
            {


                SqlCommand command = new SqlCommand(string.Format(Resources.UpdateItem, code, description, itemType, price, cost, id), DBController._SqlConnection);
                int rowsAffected = command.ExecuteNonQuery();



            }
            else
            {

                MessageBox.Show("Please fill all fields with valid values!");
            }
        }

        private void gridItem_Click(object sender, EventArgs e) {

        }
    }
}


