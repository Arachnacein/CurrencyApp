using System.Net;
using static CurrencyApp.Logic.Const.ConstValues;

namespace CurrencyApp.Logic
{
    public class Factoria
    {      
        public WebClient ConfigureMetalService()
        {
            WebClient webClient = new WebClient();
            webClient.Headers.Add("Content-Type", "application/json");
            webClient.Headers.Add("x-access-token", metalxAccessToken);
            return webClient;
        }       
        public WebClient ConfigureCurrencyService()
        {
            WebClient webClient = new WebClient();
            webClient.Headers.Add("Content-Type", "application/json");
            webClient.Headers.Add("apikey", currencyApiKey);
            return webClient;
        }
    }
}
