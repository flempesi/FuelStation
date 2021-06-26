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
    public partial class ItemViewForm : DevExpress.XtraEditors.XtraForm {
        public DataSet ViewData { get; set; }

        public DatabaseConnectionController DBController { get; set; }

        public ItemViewForm() {
            InitializeComponent();
        }
    }
}
