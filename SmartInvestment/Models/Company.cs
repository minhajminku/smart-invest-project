using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInvestment.Models
{
    public class Company
    {
        public int Company_Id { get; set; }
        public string Company_Name { get; set; }
        public decimal Current_Stock_Value { get; set; }
        public decimal Prev_Month_Stock_Value { get; set; }
        public string RiskName { get; set; }
        public string CategoryName { get; set; }
        public string SectorName { get; set; }
        public string CountryName { get; set; }
        public bool IsSelected { get; set; }
        public int CategoryId { get; set; }
        public int CountryId { get; set; }
        public int RiskId { get; set; }
        public int SectorId { get; set; }


    }
}
