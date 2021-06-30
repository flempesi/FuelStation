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

namespace FuelStationProject.WUI {
    public partial class EmployeeForm : DevExpress.XtraEditors.XtraForm {
        public DatabaseConnectionController DBController { get; set; }
        public EmployeeForm() {
            InitializeComponent();
        }

        private void ctlrCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            InsertEmployee();
        }
        public void InsertEmployee() {
            string name = Convert.ToString(ctrlName.EditValue);
            string surname = Convert.ToString(ctrlSurname.EditValue);
            DateTime dateStart;
            DateTime date;
            DateTime? dateEnd = null;
            decimal salary;
            if (ctrlDateEnd.EditValue != null) {
                dateEnd = DateTime.TryParse(Convert.ToString(ctrlDateEnd.EditValue), out date) ? date : (DateTime?)null;
            }

            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(surname) &&
                  decimal.TryParse(Convert.ToString(ctrlSalary.EditValue), out salary) && salary > 0
                  && DateTime.TryParse(Convert.ToString(ctrlDateStart.EditValue), out dateStart)) {
                if (dateStart <= dateEnd || dateEnd== (DateTime?)null) {
                    SaveToDB(name, surname, dateStart, dateEnd, salary);

                    Close();
                }
                else {

                    MessageBox.Show("DateStart must be earlier than DateEnd");
                }

            }
            else {

                MessageBox.Show("Please fill all fields with valid values!");
            }
        }

        private void SaveToDB(string name, string surname, DateTime dateStart, DateTime? dateEnd, decimal salary) {
            SqlCommand command = new SqlCommand(string.Format(Resources.InsertEmployee, name, surname, dateStart, dateEnd, salary), DBController._SqlConnection);
            int rowsAffected = command.ExecuteNonQuery();
        }

        private void EmployeeForm_Load(object sender, EventArgs e) {
            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            CultureInfo.CurrentUICulture = new CultureInfo("en-US", false);
        }
    }
}
