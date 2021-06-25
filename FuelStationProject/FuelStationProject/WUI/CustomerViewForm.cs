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

namespace FuelStationProject.WUI {
    public partial class CustomerViewForm : DevExpress.XtraEditors.XtraForm {

        public CustomerController newcc { get; set; }
        public DatabaseConnectionController newdcc { get; set; }

        public SqlConnection NewSqlConnection;

        public CustomerViewForm() {
            InitializeComponent();
        }

        private void CustomerViewForm_Load(object sender, EventArgs e) {
            //CustomerController cc = new CustomerController();

            newcc.GetCustomers(gridControl1, NewSqlConnection);
        }
    }
}
