using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace CountryBrowser
{
    public class ApiCall
    {
        public static async Task<CountryModel> LoadCountry (string countryName)
        {
            string url =
                "https://restcountries.eu/rest/v2/name/" +
                $"{countryName}?fullText=true" +
                "&fields=name;alpha2Code;capital;area;population;region";            
            
            using (HttpResponseMessage response = await UI.Client.GetAsync(url))
            {
                string countryJson = response.Content.ReadAsStringAsync()
                    .Result.Replace("[", "").Replace("]", "");

                return JsonConvert.DeserializeObject<CountryModel>(countryJson);
            }   
        }
    }
}