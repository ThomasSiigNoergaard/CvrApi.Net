using CvrApi.Net.Requests;

namespace CvrApi.Net.Client
{
  internal interface IUrlBuilder
  {
    string Build(CvrApiRequest request);
  }
}