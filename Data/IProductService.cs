using System.Collections.Generic;
using System.Security.Policy;
using System.Threading.Tasks;

namespace BlazorShop.Data
{
    public interface IProductService
    {
        Task<List<Product>> GetProductsAsync(string category);
        Product GetProduct(int id);
        Task<HashSet<string>> GetCategoriesAsync();

        HashSet<string> GetCategories();
    }
}