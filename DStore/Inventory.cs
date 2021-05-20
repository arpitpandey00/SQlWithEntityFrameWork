using System;
using System.Collections.Generic;
using System.Text;

namespace DStore.Data
{
    public class Inventory
    {
        public int ProductId { get; set; }
        public int ProductQuantity { get; set; }
        public Product Product { get; set; }

    }
}
