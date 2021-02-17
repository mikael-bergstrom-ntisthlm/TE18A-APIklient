using System;
using RestSharp;
using Newtonsoft.Json;

namespace APIklient
{
  class Program
  {
    static void Main(string[] args)
    {
      RestClient client = new RestClient("https://pokeapi.co/api/v2/");

      RestRequest request = new RestRequest("pokemon/grejsimojs");
      IRestResponse response = client.Get(request);

      Console.WriteLine(response.StatusCode);

      if (response.StatusCode == System.Net.HttpStatusCode.OK)
      {
        Pokemon thePokemon = JsonConvert.DeserializeObject<Pokemon>(response.Content);

        Console.WriteLine(thePokemon.name);
      }


      Console.ReadLine();
    }
  }
}
