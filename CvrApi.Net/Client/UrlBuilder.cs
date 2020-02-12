using CvrApi.Net.Requests;

namespace CvrApi.Net.Client
{
  internal class UrlBuilder : IUrlBuilder
  {
    public string Build(CvrApiRequest request)
    {
      var url = "?search=";

      if (request.SearchMethod == SearchMethod.Name && request is CvrApiNameRequest nameRequest)
      {
        url += nameRequest.Name;
      }
      else if (request.SearchMethod == SearchMethod.OrganisationNumber && request is CvrApiNumberRequest numberRequest)
      {
        url += numberRequest.OrganisationId.ToString();
      }

      switch (request.Country)
      {
        case CountryEnum.DK:
          url += "&country=dk";
          break;
        case CountryEnum.NO:
          url += "&country=no";
          break;
      }

      return url;
    }
  }
}