using AutoMapper;
using DStore.Data;
using DStoreApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DStoreApi.Mapper
{
    public class StaffProfile : Profile
    {
        public StaffProfile()
        {
            this.CreateMap<Staff,StaffModel>();
        }
    }
}
