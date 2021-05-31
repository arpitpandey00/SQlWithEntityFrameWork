using AutoMapper;
using DStore.Data.Infrastructure;
using DStoreApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DStoreApi.Controllers
{
    [Route("api/staff-address")]
    [ApiController]
    public class StaffAddressController : ControllerBase
    {
        DStoreContext _context;
        public readonly IMapper MapperStaffRole;
        public StaffAddressController(DStoreContext context, IMapper mapper)
        {
            _context = context;
            MapperStaffRole = mapper;
        }

        [HttpGet]
        public IActionResult GetStaffRole()
        {
            var query = _context.Staffs.Include(l => l.Address).ToList();
            List<StaffAddressModel> staffAddressModels = MapperStaffRole.Map<List<StaffAddressModel>>(query);
            return Ok(staffAddressModels);
        }
    }
}
