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

        public ProductServiceHttp(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<Product>> GetProducts()
        {
            return await _http.GetFromJsonAsync<List<Product>>("api/Product");
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
