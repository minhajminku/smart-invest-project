using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInvestment.Models
{
   public class Client
    {
        public int ClientId { get; set; }
        public string Client_First_Name { get; set; }
        public string Client_Last_Name { get; set; }
        public string Client_Gender { get; set; }
        public string Dmat_Number { get; set; }
        public string Mobile_Number { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
