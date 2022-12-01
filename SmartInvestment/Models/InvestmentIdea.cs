using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInvestment.Models
{
    public class InvestmentIdea
    {
        public int? IdeaId { get; set; }
        public string Idea_Name { get; set; }
        public int CategoryID { get; set; }
        public DateTime CreatedDate { get; set; }

    }
    public class InvestmentIdeaSelect
    {
        public int? IdeaId { get; set; }
        public string Idea_Name { get; set; }
    }
}
