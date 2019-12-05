using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NutriBalance.EdanamApi
{
    public class RestService
    {
        HttpClient _client;

        public RestService()
        {
            _client = new HttpClient();
        }

        public async Task<NutritionalFacts> GetNutritionalData(string query)
        {
            NutritionalFacts nutritionalFactsData = null;
            try
            {
                var response = await _client.GetAsync(query);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    nutritionalFactsData = JsonConvert.DeserializeObject<NutritionalFacts>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("\t\tERROR {0}", ex.Message);
            }

            return nutritionalFactsData;
        }
    }
}

   
