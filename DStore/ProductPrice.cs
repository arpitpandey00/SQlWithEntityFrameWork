using System;
using System.Collections.Generic;
using System.Text;

namespace DStore.Data
{
    public class ProductPrice
    {
        public int ProductPriceId { get; set; }
        public int ProductId { get; set; }
        public string Month { get; set; }
        public int CostPrice { get; set; }
        public int SellingPrice { get; set; }
        public Boolean IsActive { get; set; }

        public Product Product { get; set; }
       
    }
}
