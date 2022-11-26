using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInvestment.Models
{
   public class InvestmentCategory
    {
        public int CategoryId { get; set; }
        public string Category_Name { get; set; }
        public DateTime CreatedDate { get; set; }

    }
    public class InvestmentCategorySelect
    {
        public int CategoryId { get; set; }
        public string Category_Name { get; set; }
        public bool IsSelected { get; set; }

    }

    public class GenderSelect
    {
        public int GenderId { get; set; }
        public string Gender_Name { get; set; }

    }
}
