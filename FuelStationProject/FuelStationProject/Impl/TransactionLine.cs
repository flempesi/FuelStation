using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationProject.Impl {
    class TransactionLine :Entity{

        public Guid TransactionID { get; set; }

        public Guid ItemID { get; set; }


        public decimal Quantity { get; set; }

        public decimal ItemPrice { get; set; }

        public decimal Value { get; set; }


        public TransactionLine() {
                
        }



    }
}
