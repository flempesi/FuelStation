using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStationProject.Impl {
    class Transaction {

        public Guid ID { get; set; }
        public DateTime Date { get; set; }

        public Guid CustomerID { get; set; }


        public decimal DiscountValue { get; set; }


        public decimal TotalValue { get; set; }
        public decimal TotalCost { get; set; }

        public List<TransactionLine> TransactionLines { get; set; }

        public Transaction() {

        }

    }
}
