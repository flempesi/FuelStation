using FuelStationProject.Controllers;
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
    public partial class EmployeeViewForm : DevExpress.XtraEditors.XtraForm
    {
        public DataSet ViewData { get; set; }

        public DatabaseConnectionController DBController { get; set; }

        public EmployeeViewForm()
        {
            InitializeComponent();
        }

        private void EmployeeViewForm_Load(object sender, EventArgs e)
        {

            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            CultureInfo.CurrentUICulture = new CultureInfo("en-US", false);

            RefreshEmployeeGrid();
        }
        private void repSaveButtonEdit_Click(object sender, EventArgs e)
        {
            SaveButtonCode();

        }

        private void repdeleteButtonEdit_Click(object sender, EventArgs e)
        {
            DeletebuttonCode();

        }



        private void SaveButtonCode()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Change this entry ?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {

                UpdateEmployee();
                RefreshEmployeeGrid();

            }
        }


        private void DeletebuttonCode()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this entry ?", "Warning", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {


                SqlCommand command = new SqlCommand(string.Format(Resources.DeleteEmployee, Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID"))), DBController._SqlConnection);

                int rowsAffected = command.ExecuteNonQuery();
                RefreshEmployeeGrid();

            }
        }

        private void RefreshEmployeeGrid()
        {
            ViewData = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(Resources.SelectEmployeeTable, DBController._SqlConnection);
            int response = adapter.Fill(ViewData);

            gridView1.OptionsView.ShowGroupPanel = false;
            gridEmployee.DataSource = ViewData.Tables[0];

        }

        public void UpdateEmployee()
        {
            Guid id = Guid.Parse(Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID")));
            string name = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Name"));
            string surname = Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Surname"));
            DateTime dateStart;
            DateTime date;
            DateTime? dateEnd = null;
            decimal salary;
            if (gridColumnDateEnd != null)
            {
                dateEnd = DateTime.TryParse(Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DateEnd")), out date) ? date : (DateTime?)null;
            }

            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(surname) &&
                  decimal.TryParse(Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Salary")).Replace(',', '.'), out salary) && salary > 0
                  && DateTime.TryParse(Convert.ToString(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DateStart")), out dateStart))
            {


                SqlCommand command = new SqlCommand(string.Format(Resources.UpdateEmployee, name, surname, dateStart, dateEnd, salary, id), DBController._SqlConnection);
                int rowsAffected = command.ExecuteNonQuery();



            }
            else
            {

                MessageBox.Show("Please fill all fields with valid values!");
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshEmployeeGrid();
        }
    }
}
