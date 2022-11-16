using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInvestment.Database
{
    public static class SqlQueries
    {
        private static string query = "";
        private static string condition = "";
        public static string GetUserByName_Password(string username, string password) 
        {
           return String.Format("SELECT User_Name,Email,Password FROM dbo.Users WHERE User_Name = '{0}' AND Password = '{1}' ", username, password) ;
        }
        public static string GetInvestmentCategories(int? invstCategiryId = null)
        {
            condition = invstCategiryId != null ? " WHERE Investment_Category_Id = " + invstCategiryId : " ";
           
            return String.Format("SELECT Investment_Category_Id,Investment_Category_Name,Created_Date FROM dbo.Investment_Category {0}", condition );
        }
        public static string GetInvestmentIdeas(int? investmentIdeaId = null)
        {
            condition = investmentIdeaId != null ? " WHERE Investment_Idea_Id = " + investmentIdeaId : " ";

            return String.Format("SELECT Investment_Idea_Id,Investment_Idea_Name,Investment_Category_Id,Created_Date FROM dbo.Investment_Idea {0}", condition);
        }
    }
}
