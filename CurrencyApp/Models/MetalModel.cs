using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyApp.Models
{
    public class MetalModel
    {
        public string Success { get; set; }
        public string Timestamp { get; set; }
        public string Base { get; set; }
        public DateTime Date { get; set; }
        public List<string> Rates { get; set; }

    }
}
