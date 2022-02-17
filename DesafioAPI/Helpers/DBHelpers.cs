using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Npgsql;
using NUnit.Framework;
using Oracle.ManagedDataAccess.Client;
namespace RestSharpNetCoreTemplate.Helpers
{
    public class DBHelpers
    {
        private static MySqlConnection DbConnection()
        {
            string connectionString = "server=127.0.0.1;uid=root;pwd=root;database=bugtracker";
            MySqlConnection connection = new MySqlConnection(connectionString);

            return connection;
        }

        public static void ExecuteQuery(string query)
        {
            using (MySqlCommand cmd = new MySqlCommand(query, DbConnection()))
            {

                cmd.CommandTimeout = Int32.Parse(JsonBuilder.ReturnParameterAppSettings("DB_CONNECTION_TIMEOUT"));
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }
        public static List<string> RetornaDadosQuery(string query)
        {
            DataSet ds = new DataSet();
            List<string> lista = new List<string>();

            using (MySqlCommand cmd = new MySqlCommand(query, DbConnection()))
            {
                cmd.CommandTimeout = Int32.Parse(JsonBuilder.ReturnParameterAppSettings("DB_CONNECTION_TIMEOUT"));
                cmd.Connection.Open();
                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);

                cmd.Connection.Close();
            }

            if (ds.Tables[0].Columns.Count == 0)
            {
                return null;
            }

            if (ds.Tables[0].Rows.Count == 0)
            {
                string result = string.Empty;
                Assume.That(!result.Equals(string.Empty), "A consulta do banco de dados não retornou nenhum registro");
            }

            try
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                    {
                        lista.Add(ds.Tables[0].Rows[i][j].ToString());
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
            return lista;
        }

        //#region PostGreSQL
        //private static NpgsqlConnection GetDBConnectionPostGreSQL()
        //{
        //    string connectionStringPostGreSQL = "Server =" +
        //        JsonBuilder.ReturnParameterAppSettings("DB_URL") + "; Port = " +
        //        JsonBuilder.ReturnParameterAppSettings("DB_PORT") + "; User Id = " +
        //        JsonBuilder.ReturnParameterAppSettings("DB_USER") + "; Password = " +
        //        JsonBuilder.ReturnParameterAppSettings("DB_PASSWORD") + "; Database = " +
        //        JsonBuilder.ReturnParameterAppSettings("DB_NAME") + ";";

        //    NpgsqlConnection connection = new NpgsqlConnection(connectionStringPostGreSQL);

        //    return connection;
        //}

        //public static void ExecuteQueryPostGreSQL(string query)
        //{
        //    using (var command = new NpgsqlCommand(query, GetDBConnectionPostGreSQL()))
        //    {
        //        command.CommandTimeout = Int32.Parse(JsonBuilder.ReturnParameterAppSettings("DB_CONNECTION_TIMEOUT"));
        //        command.Connection.Open();
        //        command.ExecuteNonQuery();
        //        command.Connection.Close();
        //    }
        //}

        //public static List<string> RetornaDadosQueryPostGreSQL(string query)
        //{
        //    DataSet ds = new DataSet();
        //    List<string> lista = new List<string>();

        //    using (NpgsqlCommand command = new NpgsqlCommand(query, GetDBConnectionPostGreSQL()))
        //    {
        //        command.CommandTimeout = Int32.Parse(JsonBuilder.ReturnParameterAppSettings("DB_CONNECTION_TIMEOUT"));
        //        command.Connection.Open();

        //        DataTable table = new DataTable();
        //        table.Load(command.ExecuteReader());
        //        ds.Tables.Add(table);

        //        command.Connection.Close();
        //    }

        //    if (ds.Tables[0].Columns.Count == 0)
        //    {
        //        return null;
        //    }

        //    try
        //    {
        //        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //        {
        //            for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
        //            {
        //                lista.Add(ds.Tables[0].Rows[i][j].ToString());
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }

        //    return lista;
        //}
        //#endregion

        //#region SQL
        //private static SqlConnection GetDBConnection()
        //{
        //    string connectionString = "Data Source=" + JsonBuilder.ReturnParameterAppSettings("DB_URL") + ";" +
        //                              "Initial Catalog=" + JsonBuilder.ReturnParameterAppSettings("DB_NAME") + "; " +
        //                              "User ID=" + JsonBuilder.ReturnParameterAppSettings("DB_USER") + "; " +
        //                              "Password=" + JsonBuilder.ReturnParameterAppSettings("DB_PASSWORD") + "; ";

        //    SqlConnection connection = new SqlConnection(connectionString);

        //    return connection;
        //}

        //public static void ExecuteQuery(string query)
        //{
        //    using (SqlCommand cmd = new SqlCommand(query, GetDBConnection()))
        //    {
        //        cmd.CommandTimeout = Int32.Parse(JsonBuilder.ReturnParameterAppSettings("DB_CONNECTION_TIMEOUT"));
        //        cmd.Connection.Open();
        //        cmd.ExecuteNonQuery();
        //        cmd.Connection.Close();
        //    }
        //}

        //public static List<string> RetornaDadosQuery(string query)
        //{
        //    DataSet ds = new DataSet();
        //    List<string> lista = new List<string>();

        //    using (SqlCommand cmd = new SqlCommand(query, GetDBConnection()))
        //    {
        //        cmd.CommandTimeout = Int32.Parse(JsonBuilder.ReturnParameterAppSettings("DB_CONNECTION_TIMEOUT"));
        //        cmd.Connection.Open();

        //        DataTable table = new DataTable();
        //        table.Load(cmd.ExecuteReader());
        //        ds.Tables.Add(table);

        //        cmd.Connection.Close();
        //    }

        //    if (ds.Tables[0].Columns.Count == 0)
        //    {
        //        return null;
        //    }

        //    try
        //    {
        //        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //        {
        //            for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
        //            {
        //                lista.Add(ds.Tables[0].Rows[i][j].ToString());
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }

        //    return lista;
        //}
        //#endregion

        //#region Oracle
        //      private static OracleConnection GetDBConnectionOracle()
        //{
        //    string connString = "DATA SOURCE="+ JsonBuilder.ReturnParameterAppSettings("DB_URL") + ";" +
        //    "PERSIST SECURITY INFO=True;USER ID="+ JsonBuilder.ReturnParameterAppSettings("DB_USER") + 
        //    "; password="+ JsonBuilder.ReturnParameterAppSettings("DB_PASSWORD") + "; Pooling = False; ";

        //    OracleConnection conn = new OracleConnection(connString);

        //    return conn;
        //}

        //public static void ExecuteQueryOracle(string query)
        //{
        //    using (OracleCommand cmd = new OracleCommand(query, GetDBConnectionOracle()))
        //    {
        //        cmd.CommandTimeout = Int32.Parse(JsonBuilder.ReturnParameterAppSettings("DB_CONNECTION_TIMEOUT"));
        //        cmd.Connection.Open();
        //        cmd.ExecuteNonQuery();
        //        cmd.Connection.Close();
        //    }
        //}

        //public static List<string> RetornaDadosQueryOracle(string query)
        //{
        //    DataSet ds = new DataSet();
        //    List<string> lista = new List<string>();

        //    using (OracleCommand cmd = new OracleCommand(query, GetDBConnectionOracle()))
        //    {
        //        cmd.CommandTimeout = Int32.Parse(JsonBuilder.ReturnParameterAppSettings("DB_CONNECTION_TIMEOUT"));
        //        cmd.Connection.Open();

        //        DataTable table = new DataTable();
        //        table.Load(cmd.ExecuteReader());
        //        ds.Tables.Add(table);

        //        cmd.Connection.Close();
        //    }

        //    if (ds.Tables[0].Columns.Count == 0)
        //    {
        //        return null;
        //    }

        //    try
        //    {
        //        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //        {
        //            for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
        //            {
        //                lista.Add(ds.Tables[0].Rows[i][j].ToString());
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }

        //    return lista;
        //}
        //#endregion
    }
}
