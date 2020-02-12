using System;
using System.Threading.Tasks;
using CvrApi.Net.Requests;
using CvrApi.Net.Responses;

namespace CvrApi.Client
{
  class Program
  {
    static async Task Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      var client = new Net.Client.CvrApiClient();

      var request = new CvrApiNameRequest()
      {
        Name = "Merc",
        Country = CountryEnum.DK
      };

      var request2 = new CvrApiNumberRequest()
      {
        OrganisationId = 25698851,
        Country = CountryEnum.DK
      };

      CvrApiResponse responseAsync = await client.GetResponseAsync(request);
      CvrApiResponse responseAsync2 = await client.GetResponseAsync(request2);

      Console.WriteLine($"{responseAsync.Address}");
    }
  }
}