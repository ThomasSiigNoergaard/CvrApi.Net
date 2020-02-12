namespace CvrApi.Net.Requests
{
  public abstract class CvrApiRequest
  {
    public CountryEnum Country { get; set; }

    internal SearchMethod SearchMethod { get; set; }

    /// <summary>
    /// Id which is set as User-Agent
    /// </summary>
    public string CallerId { get; set; } = "CvrApi.Net";
  }
}