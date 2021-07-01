using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
    public partial class ItemForm : DevExpress.XtraEditors.XtraForm {

        public DatabaseConnectionController DBController { get; set; }
        public ItemForm() {
            InitializeComponent();
        }
        private void ItemForm_Load(object sender, EventArgs e) {
            ItemFormLoad();

        }

        private void ctlrCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            InsertItem();
        }

        private void ItemFormLoad() {
            InitializeLookUpEdit();

        }

        private void InitializeLookUpEdit() {
            var itemTypes = new List<ItemType>() {
                    new ItemType() {  Value = ItemTypeCategoryEnum.Fuel,NumberOfValue= Convert.ToInt16(ItemTypeCategoryEnum.Fuel), Description = "Fuel" },
                    new ItemType() {  Value = ItemTypeCategoryEnum.Product,NumberOfValue= Convert.ToInt16(ItemTypeCategoryEnum.Product), Description = "Product" },
                    new ItemType() {  Value = ItemTypeCategoryEnum.Service,NumberOfValue= Convert.ToInt16(ItemTypeCategoryEnum.Service), Description = "Service" },
                };
            ctrlItemType.Properties.DataSource = itemTypes;
            ctrlItemType.Properties.ValueMember = "NumberOfValue";
            ctrlItemType.Properties.DisplayMember = "Description";
            ctrlItemType.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description"));
            ctrlItemType.Properties.ShowHeader = false;
        }

        public void InsertItem() {
            string code = Convert.ToString(ctrlCode.EditValue);
            string description = Convert.ToString(ctrlDescription.EditValue);
            string item = Convert.ToString(ctrlItemType.EditValue); 
            ItemTypeCategoryEnum itemType;
            decimal price, cost;


            if (!string.IsNullOrWhiteSpace(code) && !string.IsNullOrWhiteSpace(description) && !string.IsNullOrWhiteSpace(item)
                &&
                  decimal.TryParse(Convert.ToString(ctrlPrice.EditValue), out price) && price > 0
                  && decimal.TryParse(Convert.ToString(ctrlCost.EditValue), out cost) && cost > 0) {
                itemType = (ItemTypeCategoryEnum)Convert.ToInt16(ctrlItemType.EditValue);
                SaveToDB(code, description, itemType, price, cost);
                Close();
            }
            else {
                MessageBox.Show("Please fill all fields with valid values!");
            }
        }

        private void SaveToDB(string code, string description, ItemTypeCategoryEnum itemType, decimal price, decimal cost) {
            try {
                SqlCommand command = new SqlCommand(string.Format(Resources.InsertItem, code, description, Convert.ToInt16(itemType), price, cost), DBController._SqlConnection);
                int rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

    }
}
