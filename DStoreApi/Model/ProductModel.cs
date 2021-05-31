using AutoMapper;
using DStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DStoreApi.Model
{
    public class ProductModel
    {
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string Manufacturer { get; set; }
        public DateTime ExpiryDate { get; set; }
        public Boolean InStock { get; set; }
    }
}
