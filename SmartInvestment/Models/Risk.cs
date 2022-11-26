using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInvestment.Models
{
    public class Risk: RiskSelect
    {
        public DateTime CreatedDate { get; set; }

    }
    public class RiskSelect
    {
        public int Risk_Id { get; set; }
        public string Risk_Name { get; set; }
    }
}
