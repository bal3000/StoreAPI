using JWT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWT.Services
{
    public interface IBasketData
    {
        IEnumerable<Product> GetAll();
        Product Get(int id);
        Product Add(Product newProduct);
        void Delete(Product toRemove);
    }
    public class BasketData : IBasketData
    {
        static BasketData()
        {
            _products = new List<Product>();
        }

        static List<Product> _products;

        public Product Add(Product newProduct)
        {
            if(_products.Count > 0)
                newProduct.Id = _products.Max(x => x.Id) + 1;

            _products.Add(newProduct);
            return newProduct;
        }

        public Product Get(int id)
        {
            return _products.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        public void Delete(Product toRemove)
        {
            _products.Remove(toRemove);
        }
    }
}
