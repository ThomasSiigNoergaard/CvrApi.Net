using System;
using System.Net.Http;
using System.Threading.Tasks;
using CvrApi.Net.Requests;
using CvrApi.Net.Responses;
using Newtonsoft.Json;

namespace CvrApi.Net.Client
{
  public class CvrApiClient : ICvrApiClient, IDisposable
  {
    private IUrlBuilder UrlBuilder { get; set; } = new UrlBuilder();

    private string _apiBase = "https://cvrapi.dk/api";

    public string ApiBase
    {
      get => _apiBase;
      set
      {
        if (!Uri.IsWellFormedUriString(value, UriKind.Absolute))
          throw new ArgumentException("Value is not a valid absolute URL");

        if (!value.StartsWith("http://") && !value.StartsWith("https://"))
          throw new ArgumentException("Value is not a valid absolute URL");

        _apiBase = value.TrimEnd('/');
      }
    }

    public CvrApiClient()
    {
      HttpClient = new HttpClient();
    }

    public CvrApiClient(string apiBase) : this()
    {
      ApiBase = apiBase;
    }

    public CvrApiClient(string apiBase, HttpClient httpClient) : this(apiBase)
    {
      HttpClient = httpClient;
    }

    public HttpClient HttpClient { get; set; }

    public async Task<CvrApiResponse> GetResponseAsync(CvrApiRequest request)
    {
      var url = ApiBase + UrlBuilder.Build(request);

      HttpClient.DefaultRequestHeaders.Add("User-Agent", request.CallerId);

      var responseMessage = await HttpClient.GetAsync(url);
      responseMessage.EnsureSuccessStatusCode();

      var content = await responseMessage.Content.ReadAsStringAsync();
      var rootResponse = JsonConvert.DeserializeObject<CvrApiResponse>(content);

      if (rootResponse == null)
        throw new Exception("Received an invalid response." + Environment.NewLine + "Response: " + content);

      return rootResponse;
    }

    public void Dispose()
    {
      HttpClient?.Dispose();
      GC.SuppressFinalize(this);
    }
  }
}