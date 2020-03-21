using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AZApi
{
    public class Fetch
    {
        private static string BaseUrl = "https://swapi.co/api";
        public static async Task<string> ByUrl(string url)
        {
            using (var client = new HttpClient())
            {
                return await client.GetStringAsync(string.Format("{0}/{1}", BaseUrl, url));
            }
        }
    }
}
