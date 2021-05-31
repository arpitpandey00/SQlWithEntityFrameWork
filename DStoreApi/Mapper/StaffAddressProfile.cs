using AutoMapper;
using DStore.Data;
using DStoreApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DStoreApi.Mapper
{
    public class StaffAddressProfile : Profile
    {
        public StaffAddressProfile()
        {
            this.CreateMap<Staff, StaffAddressModel>().ForMember(des => des.AddressLine1, act => act.
              MapFrom(scr => scr.Address.AddressLine1)).ForMember(des => des.AddressLine2, act => act.
                 MapFrom(scr => scr.Address.AddressLine2)).ForMember(des => des.City, act => act.
                 MapFrom(scr => scr.Address.City)).ForMember(des => des.State, act => act.
                 MapFrom(scr => scr.Address.State)).ForMember(des => des.Pincode, act => act.
                 MapFrom(scr => scr.Address.Pincode)).ReverseMap();
        }
    }
}
