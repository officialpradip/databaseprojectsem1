using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Nepal
{
    class dbconnection
    {
        private static object adapter;

        public static SqlConnection Dbconnect()
        {
            var conn = new SqlConnection();
            
            conn.ConnectionString = "Data Source=CTRLSOFT-BJMIA6\\SQLEXPRESS;Initial Catalog=MusicNepal;Integrated Security=True";
            
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();

            }

            return conn;
        }

        internal static object GetTableByQuery(object p)
        {
            throw new NotImplementedException();
        }

        public static DataTable GetTableByQuery(string SqlQuery)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = Dbconnect();
                command.CommandText = SqlQuery;
                command.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;

            }

            catch (Exception)
            {
                throw;

            }
        }
        public static void ExecuteNonQuery(string SqlQuery)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.Connection = Dbconnect();
                command.CommandText = SqlQuery;
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
