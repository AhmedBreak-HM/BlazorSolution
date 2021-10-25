using Blazor.WASM.Models;
using System.Collections.Generic;
using System.Linq;

namespace Blazor.WASM.Services
{
    class TestImplementWhere
    {
        public List<Product> products = new List<Product>();

        private List<Product> TestIFWhere()
        {
            var prods = products.Where(e => e.Id == 1 || e.Id == 2 || e.Id == 3);
            return prods.ToList();
        }
    }
}
