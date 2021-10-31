using Blazor.Contracts;
using Blazor.Models;
using Blazor.WASM.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;



namespace Blazor.WASM.Services
{
    public class ProductServiceHttp : IProductServiceHttp
    {
        private readonly HttpClient _http;
        private readonly string baseUrl;
        private string exceptionMessage;

        public ProductServiceHttp(HttpClient http)
        {
            _http = http;
            baseUrl = "api/Product";
        }

        public async Task<Product> AddProduct(Product product)
        {
            var respon = await _http.PostAsJsonAsync<Product>($"{baseUrl}/Add", product);
            if (!respon.IsSuccessStatusCode)
                return await respon.Content.ReadFromJsonAsync<Product>();
            throw new Exception("cant add products");
            // return null;    
        }

        public async Task<string> DeleteProduct(int id)
        {
            var respon = await _http.DeleteAsync($"{baseUrl}/{id}");
            return await respon.Content.ReadAsStringAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            var respon = await _http.GetFromJsonAsync<Product>($"{baseUrl}/GetById/{id}");
            return respon;
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _http.GetFromJsonAsync<List<Product>>(baseUrl);
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            try
            {
                var respon = await _http.PostAsJsonAsync<Product>($"{baseUrl}/Update", product);
                return await respon.Content.ReadFromJsonAsync<Product>();
            }
            catch (NotSupportedException exception)
            {
                exceptionMessage = exception.Message;
                return null;
            }
        }



        //    var response = await httpClient.GetAsync($"api/hotelroom");
        //        if (response.IsSuccessStatusCode)
        //        {
        //            var content = await response.Content.ReadAsStringAsync();
        //            var room = JsonConvert.DeserializeObject<HotelRoomDTO>(content);
        //            return room;
        //        }
        //        else
        //        {
        //            var content = await response.Content.ReadAsStringAsync();
        //            var error = JsonConvert.DeserializeObject<ErrorDTO>(content);
        //            throw new Exception(error.ErrorMessage);
    }


}
