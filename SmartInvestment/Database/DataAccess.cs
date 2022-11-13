using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SmartInvestment.Database
{
    public class DataAceess
    {
        private SqlDataAdapter oAdapter;
        private SqlCommand oCommand;
        private DataSet oDataSet;
        public string sConnectionString;

        public DataAceess()
        {
            try
            {
                sConnectionString = ConfigurationManager.ConnectionStrings["SMART_INVESTMENT_DB_Connection"].ConnectionString;
                SqlConnection sqlConnStr = new SqlConnection(sConnectionString);
                sqlConnStr.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public DataSet getDataSet(string oCommandString, SqlParameter[] oaSqlParam, Boolean isProc = true)
        {
            int iResult;

            try
            {
                oCommand = new SqlCommand(oCommandString, new SqlConnection(sConnectionString));
                oCommand.Connection.Open();
                if (isProc == true)
                {
                    oCommand.CommandType = CommandType.StoredProcedure;
                    foreach (SqlParameter oSqlParam in oaSqlParam)
                    {
                        oCommand.Parameters.Add(oSqlParam);
                    }

                }
                else
                {
                    oCommand.CommandText = oCommandString;
                }
                oAdapter = new SqlDataAdapter(oCommand);
                oDataSet = new DataSet();
                iResult = oAdapter.Fill(oDataSet);
                return oDataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                oCommand.Connection.Close();
            }

        }
        public DataSet getDataSet(string oCommandString, Boolean isProc = true)
        {
            int iResult;

            try
            {
                oCommand = new SqlCommand(oCommandString, new SqlConnection(sConnectionString));
                oCommand.Connection.Open();
                if (isProc == true)
                {
                    oCommand.CommandType = CommandType.StoredProcedure;
                }
                else
                {
                    oCommand.CommandText = oCommandString;
                }
                oAdapter = new SqlDataAdapter(oCommand);
                oDataSet = new DataSet();
                iResult = oAdapter.Fill(oDataSet);
                return oDataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                oCommand.Connection.Close();
            }

        }
        public SqlDataReader getDataReader(string oProc, SqlParameter[] oaSqlParam, Boolean isProc = true)
        {

            try
            {
                oCommand = new SqlCommand(oProc, new SqlConnection(sConnectionString));
                oCommand.Connection.Open();
                oCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader oReader;
                if (oaSqlParam != null)
                {
                    foreach (SqlParameter oSqlParam in oaSqlParam)
                    {
                        oCommand.Parameters.Add(oSqlParam);
                    }
                }
                oReader = oCommand.ExecuteReader();
                return oReader;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                oCommand.Connection.Close();
            }

        }
        public void executeProc(string oCommandString, SqlParameter[] oaSqlParam, Boolean isProc = true)
        {
            try
            {
                oCommand = new SqlCommand(oCommandString, new SqlConnection(sConnectionString));
                oCommand.Connection.Open();
                if (isProc == true)
                {
                    oCommand.CommandType = CommandType.StoredProcedure;
                    foreach (SqlParameter oSqlParam in oaSqlParam)
                    {
                        oCommand.Parameters.Add(oSqlParam);
                    }
                }
                else
                {
                    oCommand.CommandText = oCommandString;
                }
                oCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                oCommand.Connection.Close();
            }
        }
        public object executeSql(string oCommandString)
        {
            try
            {
                oCommand = new SqlCommand(oCommandString, new SqlConnection(sConnectionString));
                oCommand.Connection.Open();
                oCommand.CommandText = oCommandString;
                return oCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                oCommand.Connection.Close();
            }
        }
    }
}
