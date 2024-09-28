using Newtonsoft.Json;
using System;
using System.Threading;
using static CurrencyApp.Logic.Const.ConstValues;

namespace CurrencyApp.Logic
{
    public class Service
    {
        public string GetCurrencyValue(string currency)
        {
            string fullUrlCurrency = currencySourceSiteUrl + currency;
            try
            {
                Factoria factoria = new Factoria();
                var obj = factoria.ConfigureCurrencyService();
                string rawReponse = obj.DownloadString(fullUrlCurrency);
                dynamic parsedJson = JsonConvert.DeserializeObject<dynamic>(rawReponse);
                var ratesValue = parsedJson["rates"];

                string result = Convert.ToString(ratesValue);
                return result.Substring(12, 5);
            }
            catch (Exception exc)
            {
                return "Error";
            }
        }

        public string GetMetalValue(string currency, string metalSymbol, string sourceSiteUrl = metalSourceSiteUrl)
        {
            string fullUrl = sourceSiteUrl + metalSymbol + "/" + currency;
            try
            {
                Factoria factoria = new Factoria();
                var obj = factoria.ConfigureMetalService();
                string rawReponse = obj.DownloadString(fullUrl);
                dynamic parsedJson = JsonConvert.DeserializeObject<dynamic>(rawReponse);
                var priceValue = parsedJson["price"];

                Thread.Sleep(100); // API allows 5 requests per second
                return priceValue;
            }
            catch (Exception exc)
            {
                return "Error";
            }
        }

        public string GetGoldSiverRatio(string goldRate, string silverRate)
        {
            if (!goldRate.Equals("Error") && !silverRate.Equals("Error"))
            {
                double parsedGoldRate = Double.Parse(goldRate.Replace(".",","));
                double parsedSIlverRate = Double.Parse(silverRate.Replace(".", ","));
                return Math.Round(parsedGoldRate / parsedSIlverRate, 2).ToString();
            }
            return "Error";
        }
        public string GetCurrentDate() => DateTime.Now.ToString("g");
    }
}