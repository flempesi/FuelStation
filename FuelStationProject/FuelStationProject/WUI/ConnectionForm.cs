using FuelStationProject.Controllers;
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

namespace FuelStationProject.WUI
{
    public partial class ConnectionForm : DevExpress.XtraEditors.XtraForm
    {
        public DatabaseConnectionController _DBConnection2 { get; set; }



        public ConnectionForm()
        {
            InitializeComponent();
        }
        private void ConnectionForm_Load(object sender, EventArgs e) {

        }

        //open connection through an object of DatabaseConnectionController class
        private void btnOK_Click_1(object sender, EventArgs e)
        {
            TryConnectingToDB();

        }

        private void TryConnectingToDB()
        {
            string connString = Convert.ToString(ctrlConnectionString.EditValue);
            _DBConnection2 = new DatabaseConnectionController();


            try
            {

                _DBConnection2.Connect(connString);

                DialogResult = DialogResult.OK;

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                DialogClosing();


            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogClosing();
        }

        private void DialogClosing()
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }



        private void ConnectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogClosing();

        }

        private void ctrlConnectionString_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                TryConnectingToDB();
            }
        }
    }
}
