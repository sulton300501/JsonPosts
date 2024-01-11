using System.Text;
using System.Text.Json;


namespace ConsoleApp41
{
    public class Program
    {
    /*    static void Main(string[] args)
        {
*/
            /* Bu post qismi */
            /*    var postData = new PostData
                {
                    UserId = 9,

                    Title="Sirdarya",
                    Body="jdjd djjd"
                };

                var client = new HttpClient();
                client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");

                var json = JsonSerializer.Serialize(postData);
                var content = new StringContent(json,Encoding.UTF8,"application/json");

                var response = client.PostAsync("posts", content).Result;

                if(response.IsSuccessStatusCode) {
                    var responseContent = response.Content.ReadAsStringAsync().Result;
                    var postResponse = JsonSerializer.Deserialize<PostResponse>(responseContent);
                    Console.WriteLine(postResponse);
                }
                else
                {
                    Console.WriteLine("Error: "+response.StatusCode);
            }
            }*/


            /* Bu post qismi */

            /* Get qismi*/


         /*     public static HttpClient sharedClient = new()
              {
                  BaseAddress = new Uri("https://jsonplaceholder.typicode.com")



              };

        static async Task Main(string[] args)
        {

            await HttpMethods.GetAsync(sharedClient);





        }*/


        /* Get qismi*/


        /*Delete qismi*/

        /*   public static HttpClient sharedClient = new()
           {
               BaseAddress = new Uri("https://jsonplaceholder.typicode.com")



           };

           static async Task Main(string[] args)
           {

               await DeleteData.DeleteAsync(sharedClient);





           }*/






    }

    /*Delete qismi*/





}
/*}*/