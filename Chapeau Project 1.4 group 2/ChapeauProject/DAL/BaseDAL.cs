﻿
using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DAL
{
    public abstract class BaseDAL
    {
        protected SqlDataAdapter adapter;
        protected SqlConnection conn;

        public BaseDAL()
        {
           

            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ChapeauDatabase"].ConnectionString);
            adapter = new SqlDataAdapter();
        }

        protected SqlConnection OpenConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
                {
                    conn.Open();
                }
            }
            catch (Exception e)
            {
                //Print.ErrorLog(e);
                throw new Exception(e.Message);
            }
            return conn;
        }

        private void CloseConnection()
        {
            conn.Close();
        }

        /* For Insert/Update/Delete Queries with transaction */
        protected void ExecuteEditTranQuery(string query, SqlParameter[] sqlParameters, SqlTransaction sqlTransaction)
        {
            SqlCommand command = new SqlCommand(query, conn, sqlTransaction);

            try
            {
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                //Print.ErrorLog(e);
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        /* For Insert/Update/Delete Queries */
        protected void ExecuteEditQuery(string query, SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                // Print.ErrorLog(e);
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }


        public int ExecuteEditQueryWithResult(string query, SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                int affectedRows = command.ExecuteNonQuery();
                return affectedRows;
            }
            catch (SqlException e)
            {
                // Print.ErrorLog(e);
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        /* For Select Queries */
        protected DataTable ExecuteSelectQuery(string query, params SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();
            DataTable dataTable;
            DataSet dataSet = new DataSet();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                command.ExecuteNonQuery();
                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
            }
            catch (SqlException e)
            {
                // Print.ErrorLog(e);
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }

            return dataTable;
        }

        protected void ExecuteAddQuery(string query, SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                // Print.ErrorLog(e);
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        protected int ExecuteInsertQuery(string query, SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();
            int insertedId = 0;

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query + "; SELECT SCOPE_IDENTITY();";
                command.Parameters.AddRange(sqlParameters);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    insertedId = Convert.ToInt32(result);
                }

                return insertedId;
            }
            catch (SqlException e)
            {
                // Print.ErrorLog(e);
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        protected object ExecuteScalarQuery(string query, SqlParameter[] sqlParameters = null)
        {
            SqlCommand command = new SqlCommand();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                if (sqlParameters != null)
                {
                    command.Parameters.AddRange(sqlParameters);
                }

                object result = command.ExecuteScalar();
                return result;
            }
            catch (SqlException e)
            {
                // Print.ErrorLog(e);
                throw new Exception(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
