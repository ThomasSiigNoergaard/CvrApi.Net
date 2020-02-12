using Newtonsoft.Json;

namespace CvrApi.Net.Responses
{
  public class ProductionUnit
  {
    [JsonProperty("pno")]
    public string ProductionNumber { get; set; }

    public bool Main { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }

    public int ZipCode { get; set; }

    public string City { get; set; }

    public string CityName { get; set; }

    public bool Protected { get; set; }

    public string Phone { get; set; }

    public string Email { get; set; }

    public string Fax { get; set; }

    public int IndustryCode { get; set; }

    public string IndustryDesc { get; set; }
  }
}
