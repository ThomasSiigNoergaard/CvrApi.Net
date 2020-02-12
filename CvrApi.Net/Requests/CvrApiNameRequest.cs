namespace CvrApi.Net.Requests
{
  public class CvrApiNameRequest : CvrApiRequest
  {
    public CvrApiNameRequest()
    {
      SearchMethod = SearchMethod.Name;
    }

    public string Name { get; set; }
  }
}
