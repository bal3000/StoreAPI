using JWT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWT.Services
{
    public interface IProductData
    {
        IEnumerable<Product> GetAll();
        Product Get(int id);
    }

    public class ProductData : IProductData
    {
        static ProductData()
        {
            _products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Test 1",
                    Price = 2.00M,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sit amet hendrerit nulla. Proin consectetur lorem id elementum finibus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas aliquet tincidunt turpis consectetur feugiat. Praesent id quam bibendum, suscipit nibh ac, euismod nisi. Suspendisse posuere ipsum sed risus gravida convallis eu eget odio. Suspendisse dictum hendrerit tempor. Aliquam quis elementum enim, eu pellentesque ipsum.",
                    Image = "http://placehold.it/800x500",
                    Summary = new List<string> { "point 1", "point 2", "point 3" }
                },
                new Product
                {
                    Id = 2,
                    Name = "Test 2",
                    Price = 4.00M,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sit amet hendrerit nulla. Proin consectetur lorem id elementum finibus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas aliquet tincidunt turpis consectetur feugiat. Praesent id quam bibendum, suscipit nibh ac, euismod nisi. Suspendisse posuere ipsum sed risus gravida convallis eu eget odio. Suspendisse dictum hendrerit tempor. Aliquam quis elementum enim, eu pellentesque ipsum.",
                    Image = "http://placehold.it/800x500",
                    Summary = new List<string> { "point 1", "point 2", "point 3" }
                },
                new Product
                {
                    Id = 3,
                    Name = "Test 3",
                    Price = 1.40M,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sit amet hendrerit nulla. Proin consectetur lorem id elementum finibus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas aliquet tincidunt turpis consectetur feugiat. Praesent id quam bibendum, suscipit nibh ac, euismod nisi. Suspendisse posuere ipsum sed risus gravida convallis eu eget odio. Suspendisse dictum hendrerit tempor. Aliquam quis elementum enim, eu pellentesque ipsum.",
                    Image = "http://placehold.it/800x500",
                    Summary = new List<string> { "point 1", "point 2", "point 3" }
                },
                new Product
                {
                    Id = 4,
                    Name = "Test 4",
                    Price = 5.50M,
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer sit amet hendrerit nulla. Proin consectetur lorem id elementum finibus. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas aliquet tincidunt turpis consectetur feugiat. Praesent id quam bibendum, suscipit nibh ac, euismod nisi. Suspendisse posuere ipsum sed risus gravida convallis eu eget odio. Suspendisse dictum hendrerit tempor. Aliquam quis elementum enim, eu pellentesque ipsum.",
                    Image = "http://placehold.it/800x500",
                    Summary = new List<string> { "point 1", "point 2", "point 3" }
                }
            };
        }

        static IEnumerable<Product> _products;

        public Product Get(int id)
        {
            return _products.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }
    }
}
