using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShop.Data
{
    public class CartService
    {
        private List<Product> _products;

        public CartService()
        {
            _products = new List<Product>();
        }
        public List<Product> GetDistinctProducts()
        {
            return _products.Distinct().ToList();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            _products.Remove(product);
        }

        public int GetNumberOfProducts(int id)
        {
            return _products.Count(product => product.Id == id);
        }
    }
}
