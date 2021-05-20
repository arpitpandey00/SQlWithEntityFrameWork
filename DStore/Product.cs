using System;
using System.Collections.Generic;
using System.Text;

namespace DStore.Data
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string Manufacturer { get; set; }
        public DateTime ExpiryDate { get; set; }
        public Boolean InStock { get; set; }

    }
}
