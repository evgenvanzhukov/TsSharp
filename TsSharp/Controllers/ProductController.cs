using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TsSharp.Data;
using TsSharp.Models;

namespace TsSharp.Controllers
{
    [Route("api/products")]
    public class ProductController : Controller
    {
        ApplicationContext db;
        public ProductController(ApplicationContext context)
        {
            db = context;
            /*if (!db.Products.Any())
            {
                db.Products.Add(new Product { Name = "iPhone X", Price = 79900 });
                db.Products.Add(new Product { Name = "Galaxy S8", Price = 49900 });
                db.Products.Add(new Product { Name = "Pixel 2", Price = 52900 });
                db.SaveChanges();
            }*/
        }

        [HttpGet("cat{id}")]
        public IEnumerable<Product> GetProducts(int id)
        {
            return db.Products.Where(p=>p.CatId==id).ToList();
        }

        [HttpGet("{id}")]
        public Product GetProduct(int id)
        {
            Product product = db.Products.FirstOrDefault(x => x.Id == id);
            return product;
        }

        [HttpPost]
        public IActionResult Post([FromBody]Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return Ok(product);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Product product)
        {
            if (ModelState.IsValid)
            {
                db.Update(product);
                db.SaveChanges();
                return Ok(product);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Product product = db.Products.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
            }
            return Ok(product);
        }
    }
}
