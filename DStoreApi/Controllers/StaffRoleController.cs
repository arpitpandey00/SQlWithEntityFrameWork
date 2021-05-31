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
    [Route("api/Staff-role")]
    [ApiController]
    public class StaffRoleController : ControllerBase
    {
            DStoreContext _context;
            public readonly IMapper MapperStaffRole;
        public StaffRoleController(DStoreContext context, IMapper mapper)
        {
            _context = context;
            MapperStaffRole = mapper;
        }

        [HttpGet]
        public IActionResult GetStaffRole()
        {
            var query = _context.Staffs.Include(l=>l.Role).ToList();
            List<StaffRoleModel> staffRoleModels = MapperStaffRole.Map<List<StaffRoleModel>>(query);
            return Ok(staffRoleModels);
        }
    }
}
