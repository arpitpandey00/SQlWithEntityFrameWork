using AutoMapper;
using DStore.Data;
using DStoreApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DStoreApi.Mapper
{
    public class StaffRoleProfile : Profile
    {
        public StaffRoleProfile()
        {
           
            this.CreateMap<Staff, StaffRoleModel>().ForMember(dest => dest.RoleName, act => act.
              MapFrom(src => src.Role.RoleName)).ForMember(dest => dest.Description, act => act.
                MapFrom(src => src.Role.Description)).ReverseMap();
        }
    }
}
