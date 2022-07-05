using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace OrbisGame.DataAccess
{
    public class ADONETAccess
    {
        private string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\ORBIS\CaiserBot.mdf;Integrated Security=True;Connect Timeout=30";
        SqlCommand cmd = null;
        private SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(this.ConnectionString);
            if (connection.State != ConnectionState.Open)
                connection.Open();
            return connection;
        }

        //Retorne varios registros
        public DataTable GetAll(string SQLQuery, List<SqlParameter> parameters)
        {
            DataTable dataReturn = null;

            try
            {
                using (SqlConnection connection = this.GetConnection())
                {
                    SqlDataAdapter adpt = new SqlDataAdapter(SQLQuery, connection);
                    //Si se pasaron o no parametros
                    if (parameters != null && parameters.Count > 0)
                    {
                        adpt.SelectCommand.Parameters.AddRange(parameters.ToArray());
                    }
                    dataReturn = new DataTable();
                    adpt.Fill(dataReturn);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return dataReturn;
        }

        //La idea es que retorne un registro
        public DataTable GetRecord(string SQLQuery,List<SqlParameter> parameters)
        {
            DataTable dataReturn = null;

            try
            {
                using (SqlConnection connection = this.GetConnection())
                {
                    SqlDataAdapter adpt = new SqlDataAdapter(SQLQuery, connection);
                    if (parameters != null && parameters.Count > 0)
                    {
                        adpt.SelectCommand.Parameters.AddRange(parameters.ToArray());
                    }
                    dataReturn = new DataTable();
                    adpt.Fill(dataReturn);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return dataReturn;
        }

        public object Insert(String SQLQuery, List<SqlParameter> parametersList, bool ReturnValue)
        {
            object resultValue = null;
            
            try
            {
                using (SqlConnection connection = this.GetConnection())
                {
                    cmd = new SqlCommand(SQLQuery,connection);

                    if (parametersList != null && parametersList.Count > 0)
                    {
                        cmd.Parameters.AddRange(parametersList.ToArray());
                    }

                    if (ReturnValue)
                        resultValue = cmd.ExecuteScalar();
                    else
                        resultValue = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return resultValue;
        }

        public int Update(String SQLQueryUpdate, List<SqlParameter> parametersList)
        {
            int resultUpdate = 0;

            try
            {
                using (SqlConnection connection = this.GetConnection())
                {
                    cmd = new SqlCommand(SQLQueryUpdate, connection);

                    if (parametersList != null && parametersList.Count > 0)
                    {
                        cmd.Parameters.AddRange(parametersList.ToArray());
                    }

                    resultUpdate = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return resultUpdate;
        }


        public int Delete(String SQLQueryDelete, List<SqlParameter> parametersList)
        {
            int resultDelete = 0;

            try
            {
                using (SqlConnection connection = this.GetConnection())
                {
                    cmd = new SqlCommand(SQLQueryDelete, connection);

                    if (parametersList != null && parametersList.Count > 0)
                    {
                        cmd.Parameters.AddRange(parametersList.ToArray());
                    }

                    resultDelete = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return resultDelete;
        }
     
    }
}
