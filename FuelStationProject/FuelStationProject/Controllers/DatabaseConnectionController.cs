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


        public void Connect(string connectionString) {

            _SqlConnection = new SqlConnection(string.Format(@"{0}", connectionString));
            _SqlConnection.Open();

        }


    }
}
