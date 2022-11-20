using SmartInvestment.Models;
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
        public static string AddOrUpdateInvestmentIdea(InvestmentIdea idea)
        {
            condition = idea.IdeaId != null ? " WHERE Investment_Idea_Id = " + idea.IdeaId : " ";
            if (idea.IdeaId != null)
            {
                return String.Format("UPDATE dbo.Investment_Idea " +
                                    " SET Investment_Idea_Name = '{0}', " +
                                    " Investment_Category_Id = {1}, " +
                                    " Updated_By = '{2}', " +
                                    " Updated_Date = GETDATE() " +
                                    " {3}",
                                    idea.Idea_Name,
                                    idea.CategoryID,
                                    "userName",
                                    condition);
            }
            else
            {
                return String.Format("INSERT INTO dbo.Investment_Idea" +
                        "("+
                            " Investment_Idea_Name," +
                            " Investment_Category_Id," +
                            " Created_By," +
                            " Created_Date" +
                        " )" +
                        " VALUES" +
                        "( '{0}'," +
                           "{1}," +
                           " '{2}'," +
                           " DEFAULT" +
                            ")",
                            idea.Idea_Name,
                            idea.CategoryID,
                            "username");
            }
        }
        public static string DeleteIdea(int investmentIdeaId)
        {
            return String.Format("DELETE FROM dbo.Investment_Idea WHERE Investment_Idea_Id = {0}", investmentIdeaId);
        }
        public static string AddOrUpdateInvestmentCategory(InvestmentCategory category)
        {
            condition = category.CategoryId != 0 ? " WHERE Investment_Category_Id = " + category.CategoryId : " ";
            if (category.CategoryId != 0)
            {
                return String.Format("UPDATE dbo.Investment_Category " +
                                    " SET Investment_Category_Name = '{0}', " +
                                    " Updated_By = '{1}', " +
                                    " Updated_Date = GETDATE() " +
                                    " {2}",
                                    category.Category_Name,
                                    "userName",
                                    condition);
            }
            else
            {
                return String.Format("INSERT INTO dbo.Investment_Category" +
                        "(" +
                            " Investment_Category_Name," +
                            " Created_By," +
                            " Created_Date" +
                        " )" +
                        " VALUES" +
                        "( '{0}'," +
                          " '{1}'," +
                           " DEFAULT" +
                            ")",
                           category.Category_Name,
                            "username");
            }
        }
        public static string DeleteCategory(int investmentCategoryId)
        {
            return String.Format("DELETE FROM dbo.Investment_Category WHERE Investment_Category_Id = {0}", investmentCategoryId);
        }
    }
}
