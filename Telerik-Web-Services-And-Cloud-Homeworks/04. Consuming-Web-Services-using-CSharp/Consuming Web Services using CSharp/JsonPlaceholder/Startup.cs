namespace JsonPlaceholder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using Newtonsoft.Json;

    /// <summary>
    /// Note - I'm using JSONPLaceholder Api for this, as  Feedzilla API is not responding 
    /// </summary>
    public class Startup
    {
        public static void Main()
        {
            Console.Write("Please enter a string the album titles should be filtered by(example: \"et\"): ");
            var queryString = Console.ReadLine();
            var count = 10;
            Console.WriteLine("First {0} albums filtered by \"{1}\" loading...", count, queryString);
            Console.WriteLine(new string('-', 30));
            FilterAlbums(queryString, count);
        }

        private static void FilterAlbums(string queryString, int count)
        {
            using (var client = new HttpClient())
            {
                string uri = "http://jsonplaceholder.typicode.com/albums";

                client.BaseAddress = new Uri(uri);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync(string.Empty).Result;

                if (response.IsSuccessStatusCode)
                {
                    var albums = response.Content.ReadAsStringAsync().Result;
                    var albumsCollection = JsonConvert.DeserializeObject<List<Album>>(albums);
                    albumsCollection
                        .Where(a => a.Title.Contains(queryString))
                        .Take(count)
                        .ToList()
                        .ForEach(a => Console.WriteLine(a.ToString()));
                }
                else
                {
                    Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                }
            }
        }
    }
}
