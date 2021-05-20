using System;
using System.Collections.Generic;
using System.Text;

namespace DStore.Data
{
    public class Staff
    {
        public long StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public long AddressId { get; set; }
        public int RoleId { get; set; }
        public long Salary { get; set; }
        
        
        public Role Role { get; set; }
        public Address Address { get; set; }
    }
}
