using Microsoft.Data.SqlClient;


namespace MagicCardShare
{
    public class SQLConnector
    {
        public string connectionstring { get; protected set; }

        public string Datasource { get; protected set; } 
        public string DatabaseName { get; protected set; }
        public string[] TableName { get; private set; }
        public SqlConnection connection { get; protected set; }
       


        public SQLConnector(string user, string Password)
        {
            this.Datasource = @"localhost\SQLEXPRESS";
            this.DatabaseName = "Magic";
            this.connectionstring = SetConnString(user, Password);
            this.connection = new SqlConnection(connectionstring);
        }



        private string SetConnString(string user, string password)
        {

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = this.Datasource;
            builder.InitialCatalog = this.DatabaseName;
            builder.UserID = user;
            builder.Password = password;
            builder.IntegratedSecurity = false;
            builder.PersistSecurityInfo = true;
            builder.TrustServerCertificate = true;
            string connectionstring = builder.ConnectionString;
            return connectionstring;
        }

        public bool LoginSQL(string connectionstring)
        {
            bool access = false;

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                try
                {
                        connection.Open();
                        access = true;
                        
                        
                   
                }catch 
                {

                    access = false;
                }
               
            }
            return access;
        }

        public SqlDataReader SelectFrom(string Tabellenspalten, string Tabellenname,
               string BedingSpalte, string values)
        {
            using (SqlConnection Connection = new SqlConnection())
            {
                string query = "Select " + Tabellenspalten + "From " + Tabellenname +
                   "where" + BedingSpalte + "= " + "'" + values + "'";
                Connection.Open();
                SqlCommand cmd;
                SqlDataReader dataReader;
                cmd = new SqlCommand(query, Connection);
                dataReader = cmd.ExecuteReader();
                return dataReader;
            }
        }

        public SqlDataReader SelectFrom(string Tabellenspalten, string Tabellenname)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string query = "Select " + Tabellenspalten + "From " + Tabellenname;
                connection.Open();
                SqlCommand cmd;
                SqlDataReader dataReader;
                cmd = new SqlCommand(query, connection);
                dataReader = cmd.ExecuteReader();
                return dataReader;
            }
        }

        public void InsertSQL(string Tabellenname, string Tabellenspalten, string values)
        {
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string query = "Insert into " + Tabellenname + "" + Tabellenspalten + " values (" + values + ")";
                connection.Open();
                SqlCommand cmd;
                cmd = new SqlCommand(query, connection);
                new SqlParameter();
            }
        }

        private void UpdateSQL(string Tabellenname, string Tabellenspalten, string values)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionstring))
            {
                string query = "Update " + Tabellenname + "Set (" + Tabellenspalten
                                + " = '" + values + "'";
                connection.Open();
                SqlCommand cmd;
                cmd = new SqlCommand(query, connection);
            }
        }

        private void DeleteSQL(string Tabellenname, string Tabellenspalten, string values)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionstring))
            {
                string query = "Delete From " + Tabellenname + "Where " + Tabellenspalten + "= '" + values + "'";
                connection.Open();
                SqlCommand cmd;
                cmd = new SqlCommand(query, connection);
            }
        }
    }
}