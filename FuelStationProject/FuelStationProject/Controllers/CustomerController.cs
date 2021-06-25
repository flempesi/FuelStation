using FuelStationProject.Properties;
using FuelStationProject.WUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraGrid;

namespace FuelStationProject.Controllers {
    public class CustomerController {


        private DataSet _MasterData;
      //  private SqlConnection _SqlConnection;
      //  public DatabaseConnectionController _dcc { get; set; }

        private CustomerViewForm cf;

        public CustomerController() {

        }


        public void InsertCustomer(SqlConnection conn) {

          //  DatabaseConnectionController dcc = new DatabaseConnectionController();

            

            // INSERT todo insert parameters...
            SqlCommand command = new SqlCommand(Resources.InsertCustomer, conn);
            int rowsAffected = command.ExecuteNonQuery();


            // AppendLog("Rows Affected", _SqlConnection.State);


        }

        public void GetCustomers(GridControl gc, SqlConnection conn) {

            try {
                _MasterData = new DataSet();

                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Customer ", conn);
                adapter.Fill(_MasterData);





              //  gridView1.OptionsView.ShowGroupPanel = false;
                gc.DataSource = _MasterData.Tables[0];
             //   gridControl1.DataMember = _MasterData.Tables[0].TableName;

                gc.Refresh();
             //   log
              //   AppendLog("Data Set Filled", "OK");
            }
            catch (Exception ex) {
             //   AppendLog("Exception", ex.Message);
            }
        }

        public void OpenViewForm() {

            cf = new CustomerViewForm();
            cf.newcc = this;
            //cf.newdcc=this.
          //  cf.Show();


        }

        //public void Connection() {



        //    string connectionString = @"Server=localhost\SQLEXPRESS;Database=FuelStation;Trusted_Connection=True;";

        //    _SqlConnection = new SqlConnection(connectionString);
        //    _SqlConnection.Open();






        //}
   
    
    }
}
