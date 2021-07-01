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
    public partial class CustomerCheckForm : DevExpress.XtraEditors.XtraForm {

        public DataSet CustomerData { get; set; }
        public DatabaseConnectionController DBController { get; set; }
        public CustomerCheckForm() {
            InitializeComponent();
        }

        private void CustomerCheck_Load(object sender, EventArgs e) {

        }


        private void ctlrCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            SearchCustomer();
        }


        //fill a Dataset with info about a specific customer by querying the database with their CardNumber
        private void SearchCustomer() {
            CustomerData = new DataSet();

            string cardNumber = Convert.ToString(ctrlCardNumber.EditValue);
            try {
                SqlDataAdapter adapter = new SqlDataAdapter(string.Format(Resources.SelectCustomerByCardNumber, cardNumber), DBController._SqlConnection);
                int response = adapter.Fill(CustomerData);
                if (response == 1) {

                    DialogResult = DialogResult.OK;

                }
                else {

                    MessageBox.Show("Customer Not Found!Please try again!");
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        private void ctrlCardNumber_KeyDown(object sender, KeyEventArgs e) {

            if (e.KeyCode == Keys.Enter) {
                SearchCustomer();
            }
        }
    }
}
