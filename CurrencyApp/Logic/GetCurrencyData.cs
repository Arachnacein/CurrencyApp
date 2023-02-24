using Newtonsoft.Json;
using System;
using System.Net;

namespace CurrencyApp
{
    public class GetCurrencyData
    {
        private const string apiKey = "q2FW7V6hs3chCe2n4Z0ZLoej75C1NyY3";
        private const string sourceSiteUrl = "https://api.apilayer.com/exchangerates_data/latest?symbols=";

        public string GetCurrencyValue(string currency, string sourceSiteUrl = sourceSiteUrl)
        {
            string fullUrl = sourceSiteUrl + "PLN&base=" + currency;

            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Content-Type", "application/json");
                webClient.Headers.Add("apikey", apiKey);

                string rawReponse = webClient.DownloadString(fullUrl);
                dynamic parsedJson = JsonConvert.DeserializeObject<dynamic>(rawReponse);
                var ratesValue = parsedJson["rates"];
                
                string result = Convert.ToString(ratesValue);
                return result.Substring(12,5);
            }
        }
    }
}