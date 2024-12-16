using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace APIExamples
{
    internal class BookApiCalls
    {
        private static readonly HttpClient client = new HttpClient();
        private static string baseUrl = "https://fakerapi.it/api/v2/books";

        public static async Task<BookResponse?> GetBookInfoAsync(string locale, int limit, string seed)
        {
            string url = $"{baseUrl}?_locale={locale}&_quantity={limit}&_seed={seed}";
            try
            {
                using HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseMessage = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(responseMessage))
                {
                    return JsonSerializer.Deserialize<BookResponse>(responseMessage);
                }
                else
                {
                    Console.WriteLine("Could not be deserialized");
                    return null;
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
            }
          return null;

        }


    }
}
