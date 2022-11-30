﻿using SmartInvestment.Models;
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
        public static string GetClients(int? clientId = null)
        {
            condition = clientId != null ? " WHERE Client_Id = " + clientId : " ";

            return String.Format("SELECT Client_Id,Client_First_Name,Client_Last_Name,Client_Gender,Dmat_Number,Mobile_Number,Created_Date FROM dbo.Client {0}", condition);
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
        public static string AddOrUpdateclient(Client client)
        {
            condition = client.ClientId != 0 ? " WHERE Client_Id = " + client.ClientId : " ";
            if (client.ClientId != 0)
            {
                return String.Format("UPDATE dbo.Client " +
                                    " SET Client_First_Name = '{0}', " +
                                    " Client_Last_Name = '{1}', " +
                                    " Dmat_Number = '{2}', " +
                                    " Mobile_Number = '{3}', " +
                                    " Client_Gender = '{4}', " +
                                    " Updated_By = '{5}', " +
                                    " Updated_Date = GETDATE() " +
                                    " {6}",
                                    client.Client_First_Name,
                                    client.Client_Last_Name,
                                    client.Dmat_Number,
                                    client.Mobile_Number,
                                    client.Client_Gender,
                                    "userName",
                                    condition);
            }
            else
            {
                return String.Format("INSERT INTO dbo.Client" +
                        "(" +
                            " Client_First_Name," +
                            " Client_Last_Name," +
                            " Dmat_Number," +
                            " Mobile_Number," +
                            " Client_Gender,"+
                            " Created_By," +
                            " Created_Date" +
                        " )" +
                        " VALUES" +
                        "( '{0}'," +
                           " '{1}'," +
                           " '{2}'," +
                          " '{3}'," +
                          " '{4}'," +
                           " '{5}'," +
                           " DEFAULT" +
                            ")",
                             client.Client_First_Name,
                             client.Client_Last_Name,
                             client.Dmat_Number,
                             client.Mobile_Number,
                             client.Client_Gender,
                            "username");
            }
        }
        public static string DeleteClient(int clientId)
        {
            return String.Format("DELETE FROM dbo.Client WHERE Client_Id = {0}", clientId);
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
        public static string GetClientPreferenceDropDownData(int preferenceTypeID,int? clientId = null)
        {
            condition = clientId != null ? ", @Client_Id = " + clientId : " ";

            return String.Format("EXECUTE dbo.GetClientPreferenceDropDownData @Preference_Type_Id={0} {1}", preferenceTypeID,condition);
        }
        public static string DeleteAllClientPreference(int clientId)
        {
            return String.Format("DELETE FROM dbo.Client_Prferences WHERE Client_Id ={0}  ", clientId);
        }
        public static string SaveClientPreference(int clientId,int preferenceTypeId,int preference_Type_Sub_Id,string userName)
        {
            return String.Format("INSERT INTO dbo.Client_Prferences" +
                                "(" +
                                    "Client_Id," +
                                    "Preference_Type_Id," +
                                    "Preference_Type_Sub_Id," +
                                    "Created_By"+
                                ") " +
                                "VALUES" +
                                "(" +
                                "{0},{1},{2},'{3}'" +
                                ")", clientId, preferenceTypeId, preference_Type_Sub_Id, userName
                                );
        }
        public static string GetCompanyList(int? clientId = null,int? ideaId = null)
        {
            condition = clientId != null ? " WHERE Client_Id = " + clientId : " ";
            string joinCondition = ideaId != null ? "AND IIC.IdeaId = " + ideaId?.ToString() : "";

            return String.Format("SELECT CM.Company_Id,CM.Company_Name,CM.Stock_Value,CM.Previous_Month_Stock_Value,R.Risk_Name," +
                                " IC.Investment_Category_Name, S.Sector_Name, C.Country_Name,IIF(IIC.Investment_Idea_Company_Id IS NULL,0,1) AS IsSelected" +
                                " FROM dbo.Company_Master CM" +
                                " LEFT JOIN dbo.Investment_Idea_Company IIC ON IIC.CompanyId = CM.Company_Id " +
                                    joinCondition+
                                " LEFT JOIN dbo.Risk R ON R.Risk_Id = CM.RiskId" +
                                " LEFT JOIN dbo.Investment_Category IC ON IC.Investment_Category_Id = CM.CategoryId" +
                                " LEFT JOIN dbo.Sectors S ON S.Sector_Id = CM.SectorId" +
                                " LEFT JOIN dbo.Country C ON C.Country_Id = CM.CountryId {0}", condition);
        }
        public static string AddCompaniesToIdea(IdeaCompany companies,string userName = "ranjith")
        {
            string result = "";
            foreach (var companyId in companies.CompanyIds) {
                result+= String.Format("INSERT INTO dbo.Investment_Idea_Company" +
                                    " (" +
                                    " IdeaId, CompanyId, CreatedBy" +
                                    " ) " +
                                    " VALUES" +
                                    " (" +
                                    " {0},{1},'{2}'" +
                                    " );",companies.IdeaId, companyId, userName);
            }
            return result;
        }
        public static string DeleteCompaniesFromIdea(int IdeaId)
        {
            condition = " WHERE IdeaId = " + IdeaId ;
            
               return String.Format("DELETE FROM dbo.Investment_Idea_Company " +
                                    " {0}", condition);
            
        }
    }
}
