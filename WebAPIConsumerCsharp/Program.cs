using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIConsumerCsharp
{// this is used to consume service  but firstly you need to install Microsoft asp.net client  from nugets

    class Program
    {
        static void Main(string[] args)
        {
            GetProduct().Wait();
        }
        public async static Task GetProduct()
        {
            try
            {
                using (var client = new System.Net.Http.HttpClient())
                {

                    client.BaseAddress = new Uri("http://localhost:7770/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    //  new code 
                    HttpResponseMessage response = await client.GetAsync("api/products/77");
                    if (response.IsSuccessStatusCode)
                    {
                        var product = await response.Content.ReadAsAsync<Product>();
                        Console.WriteLine("{0}\t${1}\t${2}", product.ProductName, product.UnitPrice, product.UnitsInStock);
                        Console.ReadLine();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }   
}