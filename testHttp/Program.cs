using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace testHttp
{
    class Program
    {
        public static string Url = "https://randomuser.me/api/?results=1000";
        static async Task Main(string[] args)
        {

            try
            {
                UsersInfo Object = await testResult();

                Console.WriteLine(@"Скачали {0} пользователей.", Object.Results.Count());

                UsersModel context = new UsersModel();
                context.Users.Add(Object);
                await context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + ex.StackTrace);
            }

            Console.WriteLine("записали в БД");
            Console.ReadKey();
        }

        public static async Task<UsersInfo> testResult()
        {
            UsersInfo usersInfo= new UsersInfo();

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(Url);

            if (response.IsSuccessStatusCode)
            {
                string body = await response.Content.ReadAsStringAsync();

                Console.WriteLine("Что-то скачали: ");

                Console.WriteLine(body);


                Console.WriteLine("ПАРСИМ");

                usersInfo = JsonConvert.DeserializeObject<UsersInfo>(body);

                Console.WriteLine("Все ок");
            }
            else
                Console.WriteLine(response.StatusCode.ToString());

            return usersInfo;


        }
    }
}
