using System;
using System.Collections.Generic;

namespace InventoryManagement.Models
{
    public partial class Table
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Color { get; set; }
        public decimal UnitPrice { get; set; }
        public int AvailableQuatity { get; set; }
    }
}
