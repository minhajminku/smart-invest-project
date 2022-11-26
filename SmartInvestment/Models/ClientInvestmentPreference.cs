using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInvestment.Models
{
    public class ClientInvestmentPreference
    {
        public int ClientId { get; set; }
        public int PreferenceTypeId { get; set; }
        public int PreferenceTypeSubId { get; set; }
    }
}
