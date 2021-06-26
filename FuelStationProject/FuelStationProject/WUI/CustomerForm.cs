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
    public partial class CustomerForm : DevExpress.XtraEditors.XtraForm {

        public DatabaseConnectionController DBController { get; set; }


        public CustomerForm() {
            InitializeComponent();
        }


        #region Form Events

        private void CustomerForm_Load(object sender, EventArgs e) {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e) {

        }

        private void btnOK_Click(object sender, EventArgs e) {
            InsertCustomer();

        }

        private void ctlrCancel_Click(object sender, EventArgs e) {
            Close();
        }

        #endregion



        private void InsertCustomer() {
            string name = Convert.ToString(ctrlName.EditValue);
            string surname = Convert.ToString(ctrlSurname.EditValue);
            string cardNumber = Convert.ToString(ctrlCardNumber.EditValue);


            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(surname) && !string.IsNullOrWhiteSpace(cardNumber)) {


                SqlCommand command = new SqlCommand(string.Format("INSERT INTO [dbo].[Customer] (ID, [Name], [Surname], [CardNumber]) VALUES (NEWID(), '{0}', '{1}', '{2}')", name, surname, cardNumber), DBController._SqlConnection);

                int rowsAffected = command.ExecuteNonQuery();


                Close();

            }
            else {

                MessageBox.Show("All fields are required.");
            }
        }

    }
}
