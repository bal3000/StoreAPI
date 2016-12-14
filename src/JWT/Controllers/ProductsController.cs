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
    public class ProductsController : Controller
    {
        private IProductData _productData;

        public ProductsController(IProductData productData)
        {
            _productData = productData;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_productData.GetAll());
        }
        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _productData.Get(id);
            if (product != null)
                return Ok(product);
            else return NotFound();
        }
    }
}
