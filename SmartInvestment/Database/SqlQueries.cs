using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartInvestment.Database
{
    class SqlQueries
    {
        public static string GetUserByName_Password(string username, string password) 
        {
            string query = $"SELECT * FROM User WHERE username = '{username}' AND password = '{password}' ";
            return query;
        }
    }
}
