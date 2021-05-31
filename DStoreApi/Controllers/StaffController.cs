using AutoMapper;
using DStore.Data;
using DStore.Data.Infrastructure;
using DStoreApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        //public readonly RequiredQuery requiredQuery;
        DStoreContext _context;
        public readonly IMapper mapperStaff;
        public readonly LinkGenerator _linkGen;
        public StaffController(DStoreContext context, IMapper mapper,LinkGenerator linkGenerator)
        {
            _linkGen = linkGenerator;
            _context = context;
            mapperStaff = mapper ;
        }

        [HttpGet]
        public List<Staff> Staff(bool IncludeStaffAddress = false)
        {
            IQueryable<Staff> query = _context.Staffs;
                      if(IncludeStaffAddress)
            {
                query = query.Include(A => A.Address);
            }
            return query.ToList();
        }
        //[HttpGet("")]
        //public List<Staff> StaffQueryString()
        //{
        //    var query = _context.Staffs.Where(x=>x.Address.AddressId == x.AddressId).ToList();
        //    return query;
        //}
        [HttpGet("{id}")]
        public List<Staff> StaffId(long id)
        {
            var query = _context.Staffs.Where(x=>id==x.StaffId).ToList();
            return query;
        }
        [HttpGet("staff-detail")]
        public IActionResult GetStaff()
        {
            var query = _context.Staffs.ToList();
            List<StaffModel> staffModels = mapperStaff.Map<List<StaffModel>>(query);
            return Ok(staffModels);
        }

        [HttpPost]
        public IActionResult CreateStaff(Staff staff)
        {
            _context.Staffs.Add(staff);
            _context.SaveChanges();

            return Ok(staff);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateStaff(long id, Staff staff)
        {
            if (id != staff.StaffId)
            {
                return BadRequest();
            }
            _context.Entry(staff).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(staff);
          
         }
        [HttpDelete("{id}")]
        public IActionResult DeleteStaff(long id)
        {
            var query = _context.Staffs.Find(id);
            if ( query == null)
            {
                return NotFound();
            }
            _context.Staffs.Remove(query);
            _context.SaveChanges();
            return Ok(query);
        }
    }
}
