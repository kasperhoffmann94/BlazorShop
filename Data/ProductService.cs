using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace BlazorShop.Data
{
    public class ProductService : IProductService
    {
        private List<Product> products = new List<Product>
        {
            new Product
            {
                Id = 0,
                Category = "TABER",
                Color = "Rød",
                Description = "En rød taber",
                Name = "Rød Taber",
                Price = 99
            },
            new Product
            {
                Id = 1,
                Category = "VINDER",
                Color = "Grøn",
                Description = "En grøn vinder",
                Name = "Grøn Vinder",
                Price = 299
            },

        };

        private List<Product> GetProducts()
        {
            return new List<Product>();
        }
        public HashSet<string> GetCategories()
        {
            return new HashSet<string>
            {
                "TABER",
                "VINDER"
            };
            //return new HashSet<string>((GetProducts()).Select(p => p.Category).ToList());
        }

        public async Task<HashSet<string>> GetCategoriesAsync()
        {
            return new HashSet<string>
            {
                "TABER",
                "VINDER"
            };
            //return new HashSet<string>((await GetProductsAsync()).Select(p => p.Category).ToList());
        }


        public async Task<List<Product>> GetProductsAsync(string category)
        {
            return products.Where(i => i.Category == category).ToList();
        }

        public Product GetProduct(int id)
        {
            return products.FirstOrDefault(i => i.Id == id);
        }
    }
}
