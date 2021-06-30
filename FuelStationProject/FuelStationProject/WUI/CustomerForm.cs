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
    public partial class CustomerForm : DevExpress.XtraEditors.XtraForm {
        public DatabaseConnectionController DBController { get; set; }

        public CustomerForm() {
            InitializeComponent();
        }


        private void CustomerForm_Load(object sender, EventArgs e) {
            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);
            CultureInfo.CurrentUICulture = new CultureInfo("en-US", false);
        }


        private void btnOK_Click(object sender, EventArgs e) {
            InsertCustomer();

        }

        private void ctlrCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void InsertCustomer() {
            string name = Convert.ToString(ctrlName.EditValue);
            string surname = Convert.ToString(ctrlSurname.EditValue);
            string cardNumber = Convert.ToString(ctrlCardNumber.EditValue);


            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(surname) && !string.IsNullOrWhiteSpace(cardNumber)) {
                SaveToDB(name, surname, cardNumber);

                Close();

            }
            else {

                MessageBox.Show("All fields are required.");
            }
        }

        private void SaveToDB(string name, string surname, string cardNumber) {
            SqlCommand command = new SqlCommand(string.Format(Resources.InsertCustomer, name, surname, cardNumber), DBController._SqlConnection);

            int rowsAffected = command.ExecuteNonQuery();
        }
    }
}
