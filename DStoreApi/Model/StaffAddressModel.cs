using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DStoreApi.Model
{
    public class StaffAddressModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Pincode { get; set; }
        public string City { get; set; }
        public string State { get; set; }

    }
}
