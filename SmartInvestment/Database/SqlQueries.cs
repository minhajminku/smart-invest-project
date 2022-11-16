using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInvestment.Database
{
    public static class SqlQueries
    {
        public static string GetUserByName_Password(string username, string password) 
        {
            string query = String.Format("SELECT User_Name,Email,Password FROM dbo.Users WHERE User_Name = '{0}' AND Password = '{1}' ", username, password) ;
            return query;
        }
        public static string GetInvestmentCategories()
        {
            string query = String.Format("SELECT Investment_Category_Id,Investment_Category_Name,Created_Date FROM dbo.Investment_Category");
            return query;
        }
    }
}
