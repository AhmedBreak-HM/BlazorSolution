using Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Blazor.WASM.IServices
{
    public interface IProductServiceHttp
    {
        Task<List<Product>> GetProducts();
        Task<Product> GetProductById(int id);
        Task<Product> AddProduct(Product product);
        Task<Product> UpdateProduct(Product product);
        Task<string> DeleteProduct(int id);
    }
}
