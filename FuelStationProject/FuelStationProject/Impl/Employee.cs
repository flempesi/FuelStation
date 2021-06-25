using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationProject.Impl {
    class Employee :Person{

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        public decimal Salary { get; set; }

        public Employee() {

        }


    }
}
