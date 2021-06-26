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


            ComboBoxItemCollection coll = comboBoxEdit1.Properties.Items;
            coll.BeginUpdate();
            try {
                
                coll.Add("Fuel");
                coll.Add("Product");
                coll.Add("Service");
            }
            finally {
                coll.EndUpdate();
            }
            comboBoxEdit1.SelectedIndex = -1;


        }
        private void ctlrCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            InsertItem();
        }
        public void InsertItem() {
            string code = Convert.ToString(ctrlCode.EditValue);
            string description = Convert.ToString(ctrlDescription.EditValue);
            string itemType= Convert.ToString(comboBoxEdit1.EditValue);
            decimal price,cost;


            if (!string.IsNullOrWhiteSpace(code) && !string.IsNullOrWhiteSpace(description) && !string.IsNullOrWhiteSpace(itemType)
                &&
                  decimal.TryParse(Convert.ToString(ctrlPrice.EditValue), out price) && price > 0
                  && decimal.TryParse(Convert.ToString(ctrlPrice.EditValue), out cost) && cost > 0) {


               SqlCommand command = new SqlCommand(string.Format(Resources.InsertItem, code, description, itemType, price, cost), DBController._SqlConnection);
                int rowsAffected = command.ExecuteNonQuery();

                Close();

            }
            else {

                MessageBox.Show("Please fill all fields with valid values!");
            }
        }

       
    }
}
