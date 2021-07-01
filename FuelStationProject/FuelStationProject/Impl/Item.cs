using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelStationProject.Impl;

namespace FuelStationProject.Impl {
    class Item :Entity {

        public string Code { get; set; }

        public string Description { get; set; }

        public ItemTypeCategoryEnum ItemType { get; set; }

        public decimal Price { get; set; }

        public decimal Cost { get; set; }

        public Item() {

        }


    }
}
