using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationProject.Controllers {
    class EmployeeController {

        private DataSet _MasterData = new DataSet();
        private SqlConnection _SqlConnection;

        public void GetData() {

            try {

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Employee ", _SqlConnection);
                adapter.Fill(_MasterData);

                // log
               // AppendLog("Data Set Filled", "OK");
            }
            catch (Exception ex) {
               // AppendLog("Exception", ex.Message);
            }
        }








    }
}
