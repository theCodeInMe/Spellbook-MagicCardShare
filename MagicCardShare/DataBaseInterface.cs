using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace MagicCardShare
{
    public static class DataBaseInterface
    {
        public static string Connectionstring { get; private set; }

        public static void SetConnectionstring(string user, string password )
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.UserID = user;
            builder.Password = password;
            builder.DataSource =  @"localhost\SQLEXPRESS";
            builder.InitialCatalog = "Magic";
            builder.TrustServerCertificate = true;
            Connectionstring = builder.ToString();
        }

        public static bool LoginDatabase()
        {
            bool access = false;
            using (SqlConnection connection = new SqlConnection(Connectionstring))
            {
                try
                {
                    connection.Open();
                    access = true;
                }
                catch
                {
                    access = false;
                }
            }
            return access;
        }

        public static DataTable SelectFrom(string tablename, string tableColumn)
        {
            DataTable answer = new DataTable();

            using (SqlConnection connection = new SqlConnection(Connectionstring))
            {
                string query = $"Select {tableColumn} FROM {tablename}";

                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                adapter.Fill(answer);
            }
            return answer;
        }

    }
}