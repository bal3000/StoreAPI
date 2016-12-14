using JWT.Models;
using JWT.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWT.Controllers
{
    [EnableCors("SiteCorsPolicy")]
    [Route("api/[controller]")]
    public class BasketController : Controller
    {
        private IBasketData _basketData;

        public BasketController(IBasketData basketData)
        {
            _basketData = basketData;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_basketData.GetAll());
        }
        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _basketData.Get(id);
            if (product != null)
                return Ok(product);
            else return NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromBody]Product product)
        {
            if (product != null)
            {
                var newProduct = _basketData.Add(product);
                return Ok(newProduct);
            }
            else return BadRequest();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Product updatedProduct)
        {
            var product = _basketData.Get(id);
            if (product != null)
                product = updatedProduct;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {            
            _basketData.Delete(_basketData.Get(id));
        }

        [HttpDelete("deleteall")]
        public void Delete()
        {
            foreach(var bp in _basketData.GetAll())
                _basketData.Delete(bp);
        }
    }
}
