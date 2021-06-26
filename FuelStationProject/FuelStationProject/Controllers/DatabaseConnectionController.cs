using FuelStationProject.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationProject.Controllers {
  public  class DatabaseConnectionController {

        public SqlConnection _SqlConnection { get; set; }
       

        public DatabaseConnectionController() {

        }


     public   void Connection() {



            string connectionString = @"Server=localhost\SQLEXPRESS;Database=FuelStation;Trusted_Connection=True;";

            _SqlConnection = new SqlConnection(connectionString);
            _SqlConnection.Open();






        }

        //public void InsertEmployee() {

        //    // INSERT todo insert parameters...
        //    SqlCommand command = new SqlCommand(Resources.InsertEmployee, _SqlConnection);
        //    int rowsAffected = command.ExecuteNonQuery();


        //   // AppendLog("Rows Affected", _SqlConnection.State);


        //}

    }
}
