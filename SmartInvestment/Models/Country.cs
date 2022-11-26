using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInvestment.Models
{
    public class Country : CountrySelect
    {
        public string Country_Code { get; set; }
        public DateTime Created_Date { get; set; }
    }
    public class CountrySelect
    {
        public int Country_Id { get; set; }
        public string Country_Name { get; set; }
    }
}
