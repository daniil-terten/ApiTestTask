using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using TestTask.Models;

namespace TestTask.Client
{
    class ReqresClient
    {
        public HttpClient client;

        public Product[] GetProducts()
        {
            var productsResponse = client.GetAsync(GlobalVariables.APP_PATH + "/api/products").Result.Content.ReadAsStringAsync().Result;
            Product[] data = JsonConvert.DeserializeObject<ProductsResponse>(productsResponse).Data;
            return data;
        }

        public LoginResponse PostLogin(string Email = "eve.holt@reqres.in", string Password = "cityslicka")
        {
            var content = new FormUrlEncodedContent(new[]
            {
            new KeyValuePair<string, string>("email", Email),
            new KeyValuePair<string, string>("password",  Password)
            });
            var result = client.PostAsync(GlobalVariables.APP_PATH + "/api/login", content).Result.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<LoginResponse>(result);
        }
    }
}
