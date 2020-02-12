namespace CvrApi.Net.Requests
{
  public class CvrApiNumberRequest : CvrApiRequest
  {
    public CvrApiNumberRequest()
    {
      SearchMethod = SearchMethod.OrganisationNumber;
    }

    public int OrganisationId { get; set; }
  }
}