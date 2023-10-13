using System;
using System.Collections.Generic;
using System.Text;

namespace MultiColumnComboBoxSample.Shared
{
    public class Product
    {
        public int? ProductID { get; set; }
        public string ProductName { get; set; }
        public int? SupplierID { get; set; }
        public double? UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
    }
}
