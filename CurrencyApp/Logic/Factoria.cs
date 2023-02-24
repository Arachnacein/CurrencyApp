using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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
