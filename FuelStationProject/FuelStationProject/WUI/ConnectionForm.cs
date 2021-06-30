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
    public partial class ConnectionForm : Form
    {
        public DatabaseConnectionController _DBConnection2 { get; set; }



        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click_1(object sender, EventArgs e)
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
            }



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        
    }
}
