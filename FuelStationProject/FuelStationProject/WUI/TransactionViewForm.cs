using FuelStationProject.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStationProject.WUI {
    public partial class TransactionViewForm : DevExpress.XtraEditors.XtraForm {


        public DatabaseConnectionController DBController { get; set; }

        public TransactionViewForm() {
            InitializeComponent();
        }
    }
}
