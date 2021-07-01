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

namespace FuelStationProject.WUI {
    public partial class ItemViewForm : DevExpress.XtraEditors.XtraForm {
        DataSet _MasterData { get; set; }
        DataSet _MasterDataOld { get; set; }

        public DatabaseConnectionController DBController { get; set; }

        public ItemViewForm() {
            InitializeComponent();
        }


        private void ItemViewForm_Load(object sender, EventArgs e) {
            ItemViewFormLoader();

        }
        private void repSaveButtonEdit_Click(object sender, EventArgs e) {
            SaveButtonCode();

        }

        private void repdeleteButtonEdit_Click(object sender, EventArgs e) {
            DeletebuttonCode();

        }
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            RefreshItemGrid();
        }
        private void ItemViewFormLoader() {
            gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            CultureInfo.CurrentUICulture = new CultureInfo("en-US", false);

            RefreshItemGrid();

            var itemTypes = new List<ItemType>() {
                    new ItemType() {  Value = ItemTypeCategoryEnum.Fuel,NumberOfValue= Convert.ToInt16(ItemTypeCategoryEnum.Fuel), Description = "Fuel" },
                    new ItemType() {  Value = ItemTypeCategoryEnum.Product,NumberOfValue= Convert.ToInt16(ItemTypeCategoryEnum.Product), Description = "Product" },
                    new ItemType() {  Value = ItemTypeCategoryEnum.Service,NumberOfValue= Convert.ToInt16(ItemTypeCategoryEnum.Service), Description = "Service" },
                };
            repLookUpEditType.DataSource = itemTypes;
            repLookUpEditType.ValueMember = "NumberOfValue";
            repLookUpEditType.DisplayMember = "Description";
            repLookUpEditType.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description"));
            repLookUpEditType.ShowHeader = false;


        }





        private void SaveButtonCode() {
            DialogResult result = MessageBox.Show("Are you sure you want to Change this entry ?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK) {

                UpdateItem();
                RefreshItemGrid();

            }
        }


        private void DeletebuttonCode() {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this entry ?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK) {

                try {
                    SqlCommand command = new SqlCommand(string.Format(Resources.DeleteItem, Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID"))), DBController._SqlConnection);

                    int rowsAffected = command.ExecuteNonQuery();
                    RefreshItemGrid();
                }
                catch (Exception e) {
                    MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void RefreshItemGrid() {
            _MasterData = new DataSet();
            _MasterDataOld = new DataSet();
            try {
                SqlDataAdapter adapter = new SqlDataAdapter(Resources.SelectItemTable, DBController._SqlConnection);
                int response = adapter.Fill(_MasterData);
                response = adapter.Fill(_MasterDataOld);

                //gridView1.OptionsView.ShowGroupPanel = false;
                gridItem.DataSource = _MasterData.Tables[0];
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        public void UpdateItem() {
            string id = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID"));
            string code = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Code"));
            string description = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Description"));
            string temp = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ItemType"));
            ItemTypeCategoryEnum itemType ;

            decimal price, cost;

            if (!string.IsNullOrWhiteSpace(code) && !string.IsNullOrWhiteSpace(description) && !string.IsNullOrWhiteSpace(temp)
                &&
                  decimal.TryParse(Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Price")), out price) && price > 0
                  && decimal.TryParse(Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Cost")), out cost) && cost > 0) {
                     itemType = (ItemTypeCategoryEnum)Convert.ToInt16(temp);

                SaveToDB(id, code, description, itemType, price, cost);
                RefreshItemGrid();

            }
            else {

                MessageBox.Show("Please fill all fields with valid values!");
            }
        }

        private void SaveToDB(string id, string code, string description, ItemTypeCategoryEnum itemType, decimal price, decimal cost) {
            if (!string.IsNullOrWhiteSpace(id)) {

                UpdateController updateController = new UpdateController();
                string sql = updateController.UpdateEntry(id, "Item", _MasterData, _MasterDataOld);

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
                    SqlCommand command = new SqlCommand(string.Format(Resources.InsertItem, code, description, Convert.ToInt16(itemType), price, cost), DBController._SqlConnection);
                    int rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception e) {
                    MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void gridItem_Click(object sender, EventArgs e) {

        }
    }
}


