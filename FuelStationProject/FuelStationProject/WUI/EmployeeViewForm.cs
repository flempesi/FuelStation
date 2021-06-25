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
    public partial class EmployeeViewForm : Form {
        public DataSet ViewData;// = new DataSet();
        public EmployeeViewForm() {
            InitializeComponent();
        }

        private void EmployeeViewForm_Load(object sender, EventArgs e) {
            //gridControl1.Refresh();


             gridView1.OptionsView.ShowGroupPanel = false;
            
             gridEmployee.DataSource = ViewData.Tables[0];
             //gridEmployee.DataMember = ViewData.Tables[0].TableName;
        }

        private void gridEmployee_Click(object sender, EventArgs e) {

        }
    }
}
