using AutoMapper;
using DStore.Data;
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
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        DStoreContext _context;
        public readonly IMapper MapperProduct;
        public ProductController(DStoreContext context, IMapper mapper)
        {
            _context = context;
            MapperProduct = mapper;
        }
        [HttpGet]
        public List<Product> Product()
        {
            var query = _context.Products.ToList();
            return query;
        }
        [HttpGet("{id}")]
        public List<Product> ProductId(long id)
        {
            var query = _context.Products.Where(x=>id==x.ProductId).ToList();
            return query;
        }
        [HttpGet("productdetail")]
        public IActionResult Getproduct()
        {
            var query = _context.Staffs.ToList();
            List<ProductModel> productModels = MapperProduct.Map<List<ProductModel>>(query);
            return Ok(productModels);
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();

            return Ok(product);
        }
        [HttpPut("{id}")]
        public IActionResult Updateproduct(long id, Product product)
        {
            if (id != product.ProductId)
            {
                return BadRequest();
            }
            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(product);

        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(long id)
        {
            var query = _context.Staffs.Find(id);
            if (query == null)
            {
                return NotFound();
            }
            _context.Staffs.Remove(query);
            _context.SaveChanges();
            return Ok(query);
        }

    }
}
