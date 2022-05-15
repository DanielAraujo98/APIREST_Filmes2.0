using Newtonsoft.Json;
using QuickType;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace APIREST_Filmes2._0
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            Console.WriteLine("Digite o nome do filme:");
            String nomeDigitado = Console.ReadLine();

            HttpClient filmes = new HttpClient { BaseAddress = new Uri("https://jsonmock.hackerrank.com/") };
            var reponse = await filmes.GetAsync("/api/movies/search/?Title=" + nomeDigitado);
            var content = await reponse.Content.ReadAsStringAsync();

            Console.WriteLine(content);

            //Films[] films = JsonConvert.DeserializeObject<Films[]>(content);
            //var movies = films;

            //foreach (var item in movies)
            //{
            //    Console.WriteLine(item.Title);
            //}
            

        }
    }
}
