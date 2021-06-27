using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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

namespace FuelStationProject.WUI {
    public partial class ItemViewForm : DevExpress.XtraEditors.XtraForm {
        public DataSet ViewData { get; set; }

        public DatabaseConnectionController DBController { get; set; }

        public ItemViewForm() {
            InitializeComponent();
        }

        private void ItemViewForm_Load(object sender, EventArgs e) {
            RefreshItemGrid();

        }
        public void repComboBox_Popup() {
            //ComboBoxEdit coll =  Properties.Items;

            //EditorProperties().ComboBox(c =>
            //{
            //    foreach (var status in Model.VacationHourTypes) {
            //        c.Items.Add(status.Description, status.StatusId);
            //    }
            //    c.TextField = "Description";
            //    c.ValueField = "StatusId";
            //    c.ValueType = typeof(int);
            //});

            //if (gridView1.ActiveEditor is ComboBoxEdit edit) {
            //gridColumnComboBox.EditorProperties().ComboBox(c => { });
            //ComboBoxEdit edit = gridColumnComboBox.Edi;
            //    edit.Properties.Items.Clear();

            //    edit.Properties.Items.BeginUpdate();
            //    try {

            //        edit.Properties.Items.Add("Fuel");
            //        edit.Properties.Items.Add("Product");
            //        edit.Properties.Items.Add("Service");
            //    }
            //    finally {
            //        edit.Properties.Items.EndUpdate();
            //    }
                //comboBoxEdit1.SelectedIndex = -1;

          //  }
            //settings.Columns.Add(column => {
            //    column.FieldName = "CountryID";
            //    column.EditorProperties().ComboBox(cs => {
            //        cs.Width = System.Web.UI.WebControls.Unit.Percentage(100);
            //        cs.Columns.Add("CountryName");
            //        cs.Columns.Add("CountryAbbr");
            //        cs.TextFormatString = "{0}";

            //        cs.TextField = "CountryName";
            //        cs.ValueField = "CountryID";
            //        cs.ValueType = typeof(int);
            //        cs.ClientSideEvents.SelectedIndexChanged = "CountriesSelectedIndexChanged";
            //        cs.BindList(DevExpressMvcApplication1.Models.PersonsList.GetCountries());
            //    });
            //});
            //gridColumnComboBox.

            //GridView view = sender as GridView;

            //if (gridView1.ActiveEditor is ComboBoxEdit edit) {
            //    edit.Properties.Items.Clear();

            // edit.Properties.Items.Add("Fuel");
            //edit.Properties.Items.AddRange(new object[] { gridView1.FocusedRowHandle, gridView1.FocusedColumn.FieldName });//your items  
            // }
            //ComboBoxItemCollection coll =
            //gridColumnComboBox.comboBoxEdit.Properties.Items.Add("fuel");
            //comboBoxEdit1.Properties.Items.Add("fuel");
            //coll.BeginUpdate();
            //try {

            //    coll.Add("Fuel");
            //    coll.Add("Product");
            //    coll.Add("Service");
            //}
            //finally {
            //    coll.EndUpdate();
            //}
            //comboBoxEdit1.SelectedIndex = -1;
        }

        private void repSaveButtonEdit_Click(object sender, EventArgs e) {
            SaveButtonCode();

        }

        private void repdeleteButtonEdit_Click(object sender, EventArgs e) {
            DeletebuttonCode();

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


                SqlCommand command = new SqlCommand(string.Format(Resources.DeleteEmployee, Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID"))), DBController._SqlConnection);

                int rowsAffected = command.ExecuteNonQuery();
                RefreshItemGrid();

            }
        }

        private void RefreshItemGrid() {
            ViewData = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(Resources.SelectItemTable, DBController._SqlConnection);
            int response = adapter.Fill(ViewData);

          

            gridView1.OptionsView.ShowGroupPanel = false;
            gridItem.DataSource = ViewData.Tables[0];

        }

        public void UpdateItem() {
            Guid id = Guid.Parse(Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID")));
            string code = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Code"));
            string description = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Description"));
            string itemType = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ItemType"));

            decimal price,cost;

                if (!string.IsNullOrWhiteSpace(code) && !string.IsNullOrWhiteSpace(description) && !string.IsNullOrWhiteSpace(itemType)
                    &&
                      decimal.TryParse(Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Price")), out price) && price > 0
                      && decimal.TryParse(Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Cost")), out cost) && cost > 0) {


                    SqlCommand command = new SqlCommand(string.Format(Resources.UpdateItem, code, description, itemType, price, cost,id), DBController._SqlConnection);
                    int rowsAffected = command.ExecuteNonQuery();

                   

                }
            else {

                MessageBox.Show("Please fill all fields with valid values!");
            }
        }



        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            RefreshItemGrid();
        }
    }
}
    

