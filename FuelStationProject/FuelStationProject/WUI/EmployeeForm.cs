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

        private DateTime _DateEditNullDate = new DateTime(1, 1, 1, 0, 0, 0, 0);



        public EmployeeForm() {
            InitializeComponent();
        }

        private void ctlrCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            InsertEmployee();
        }
        private void EmployeeForm_Load(object sender, EventArgs e) {

        }

        //DateStart must be earlier than DateEnd and cannot be set to null
        //if DateEnd is not set(null) then the database is going to store (1900-01-01 00:00:00:000)



        public void InsertEmployee() {

            string name = Convert.ToString(ctrlName.EditValue);

            string surname = Convert.ToString(ctrlSurname.EditValue);

            DateTime dateStart = Convert.ToDateTime(ctrlDateStart.EditValue);

            DateTime dateEnd = Convert.ToDateTime(ctrlDateEnd.EditValue);

            decimal salary = Convert.ToDecimal(ctrlSalary.EditValue);

            //DateTime dt = new DateTime(1, 1, 1, 0, 0, 0, 0);

            //if(dateEnd==dt) {

            //    SaveToDB(name, surname, dateStart, dateEnd, salary);
            //}


            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(surname) && salary > 0m && dateStart != _DateEditNullDate) {

                if (dateEnd == _DateEditNullDate) {
                    SaveToDB(name, surname, dateStart, dateEnd, salary);

                    Close();
                }
                else if (dateEnd >= dateStart) {
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




        //public void InsertEmployee() {
        //    string name = Convert.ToString(ctrlName.EditValue);
        //    string surname = Convert.ToString(ctrlSurname.EditValue);
        //    DateTime dateStart;
        //    DateTime date;
        //    DateTime? dateEnd= null;
        //    decimal salary;
        //    if (ctrlDateEnd.EditValue != null) {
        //        if(DateTime.TryParse(Convert.ToString(ctrlDateEnd.EditValue), out date)) {
        //            dateEnd = date;
        //        }
        //        else {
        //            dateEnd = (DateTime?)null;
        //        }

        //    }

        //    if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(surname) &&
        //          decimal.TryParse(Convert.ToString(ctrlSalary.EditValue), out salary) && salary > 0
        //          && DateTime.TryParse(Convert.ToString(ctrlDateStart.EditValue), out dateStart)) {
        //        if (dateStart <= dateEnd || dateEnd == (DateTime?)null) {
        //            SaveToDB(name, surname, dateStart, dateEnd, salary);

        //            Close();
        //        }
        //        else {

        //            MessageBox.Show("DateStart must be earlier than DateEnd");
        //        }

        //    }
        //    else {

        //        MessageBox.Show("Please fill all fields with valid values!");
        //    }
        //}


        //private void SaveToDB(string name, string surname, DateTime dateStart, DateTime? dateEnd, decimal salary) {
        //    try {
        //        SqlCommand command = new SqlCommand(string.Format(Resources.InsertEmployee, name, surname, dateStart, dateEnd, salary), DBController._SqlConnection);
        //        int rowsAffected = command.ExecuteNonQuery();
        //    }
        //    catch (Exception e) {
        //        MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        //    }
        //}




        private void SaveToDB(string name, string surname, DateTime dateStart, DateTime dateEnd, decimal salary) {
            try {
                //DateTime dt = new DateTime(1, 1, 1, 0, 0, 0, 0);
                if (dateEnd == _DateEditNullDate) {//DateEnd null

                    SqlCommand command2 = new SqlCommand(string.Format(Resources.InsertEmployeeIfDateEndIsNull, name, surname, dateStart, salary), DBController._SqlConnection);
                    int rowsAffected2 = command2.ExecuteNonQuery();
                }
                else {//when DateEnd not null 

                    SqlCommand command = new SqlCommand(string.Format(Resources.InsertEmployee, name, surname, dateStart, dateEnd, salary), DBController._SqlConnection);
                    int rowsAffected = command.ExecuteNonQuery();


                }
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }







    }
}
