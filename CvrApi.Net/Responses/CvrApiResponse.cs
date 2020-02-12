using System.Collections.Generic;

namespace CvrApi.Net.Responses
{
  public class CvrApiResponse
  {
    public int Vat { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }

    public int Zipcode { get; set; }

    public string City { get; set; }

    public string CityName { get; set; }

    public bool Protected { get; set; }

    public string Phone { get; set; }

    public string Fax { get; set; }

    public string Employees { get; set; }

    public int IndustryCode { get; set; }

    public string IndustryDesc { get; set; }

    public int CompanyCode { get; set; }

    public List<ProductionUnit> ProductionUnits { get; set; }
  }
}