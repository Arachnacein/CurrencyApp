using System;
using System.Threading;
using System.Net;
using Newtonsoft.Json;

namespace CurrencyApp
{
    public class GetMetalData
    {
        private const string xAccessToken = "goldapi-fwg11irlehphdub-io";
        private const string SourceSiteUrl = "https://www.goldapi.io/api/";

        public string GetMetalValue(string currency, string metalSymbol, string sourceSiteUrl = SourceSiteUrl)
        {
            string fullUrl = sourceSiteUrl + metalSymbol + "/" + currency;

            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("Content-Type", "application/json");
                webClient.Headers.Add("x-access-token", xAccessToken);

                string rawReponse = webClient.DownloadString(fullUrl);
                dynamic parsedJson = JsonConvert.DeserializeObject<dynamic>(rawReponse);
                var priceValue = parsedJson["price"];

                Thread.Sleep(250); // API allows 5 requests per second
                return priceValue;
            }
        }     
    }
}