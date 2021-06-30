using FuelStationProject.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStationProject.Controllers {
    public class DatabaseConnectionController {

        public SqlConnection _SqlConnection { get; set; }


        public DatabaseConnectionController() {

        }


        public void Connection() {



            string connectionString = @"Server=localhost\SQLEXPRESS;Database=FuelStation;Trusted_Connection=True;";
            try {
                _SqlConnection = new SqlConnection(connectionString);
                _SqlConnection.Open();
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }


    }
}
