using Blazor.WASM.Contracts;
using Blazor.WASM.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.WASM.Services
{
    public class ProductService : IProductService
    {
        private List<Product> products = new List<Product>();
        public ProductService()
        {
            products.Add(new Product
            {
                Id = 1,
                Name = "Apple",
                Price = 20,
                Img = "./img/apple.jpg"
            });
            products.Add(new Product
            {
                Id = 2,
                Name = "Apricot",
                Price = 50,
                Img = "./img/apricot.jpg"
            });
            products.Add(new Product
            {
                Id = 3,
                Name = "Babaya",
                Price = 10,
                Img = "./img/babaya.jpg"
            });
            products.Add(new Product
            {
                Id = 4,
                Name = "Banana",
                Price = 15,
                Img = "./img/banana.jpg"
            });
            products.Add(new Product
            {
                Id = 5,
                Name = "Grape",
                Price = 10,
                Img = "./img/Grape.jpg"
            });
            products.Add(new Product
            {
                Id = 11,
                Name = "mango.jpg",
                Price = 10,
                Img = "./img/mango.jpg"
            });
            products.Add(new Product
            {
                Id = 6,
                Name = "Orang",
                Price = 6,
                Img = "./img/orang.jpg"
            });
            products.Add(new Product
            {
                Id = 7,
                Name = "Peache",
                Price = 50,
                Img = "./img/Peache.jpg"
            });
            products.Add(new Product
            {
                Id = 8,
                Name = "Pear",
                Price = 16,
                Img = "./img/pear.jpg"
            });
            products.Add(new Product
            {
                Id = 9,
                Name = "Pineapple",
                Price = 17,
                Img = "./img/Pineapple.jpg"
            });
            products.Add(new Product
            {
                Id = 10,
                Name = "Pomegranate",
                Price = 10,
                Img = "./img/Pomegranate.jpg"
            });
        }


        public List<Product> GetProducts() => products.ToList();

        public Product GetProductById(int id) => products.Find(p => p.Id == id);


        public void AddProduct(Product product) => products.Add(product);


        public void UpdateProduct(Product product)
        {
            var productFromRepo = GetProductById(product.Id);
            productFromRepo.Name = product.Name;
        }

        public void DeleteProduct(int id)
        {
            var productFromRepo = GetProductById(id);
            products.Remove(productFromRepo);
        }


    }
}
