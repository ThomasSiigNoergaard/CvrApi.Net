using System.Threading.Tasks;
using CvrApi.Net.Requests;
using CvrApi.Net.Responses;

namespace CvrApi.Net.Client
{
  public interface ICvrApiClient
  {
    Task<CvrApiResponse> GetResponseAsync(CvrApiRequest request);
  }
}