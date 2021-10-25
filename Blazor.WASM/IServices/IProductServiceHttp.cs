using Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.WASM.IServices
{
    public interface IProductServiceHttp
    {
        Task<List<Product>> GetProducts();
    }
}
