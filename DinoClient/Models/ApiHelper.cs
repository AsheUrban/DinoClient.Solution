using System.Threading.Tasks;
using RestSharp;

namespace DinoClient.Models
{
  public class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localHost:5000/");
      RestRequest request = new RestRequest($"api/animals", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }
  }
}