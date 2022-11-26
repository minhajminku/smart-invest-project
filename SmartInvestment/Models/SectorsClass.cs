using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInvestment.Models
{
    public class SectorsClass : SectorsSelect
    {
        public DateTime CreatedDate { get; set; }
    }
    public class SectorsSelect
    {
        public int Sector_Id { get; set; }
        public string Sector_Name { get; set; }

    }
}
