using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ConsoleApp41
{
    public class HttpMethods
    {



        public static async Task GetAsync(HttpClient httpClient)
        {
            HttpResponseMessage response = await httpClient.GetAsync("posts/3");

            response.EnsureSuccessStatusCode();



            var jsonResponse = await response.Content.ReadAsStringAsync();
            Console.WriteLine(jsonResponse);

        }



    }

}