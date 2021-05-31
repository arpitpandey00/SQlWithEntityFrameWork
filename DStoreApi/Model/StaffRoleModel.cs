﻿using DStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DStoreApi.Model
{
    public class StaffRoleModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }

      
        public string RoleName { get; set; }

        public string Description { get; set; }

    }
}
