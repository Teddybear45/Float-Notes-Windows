using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Float_Notes_win._classes
{
    public static class clsDB
    {
        public static SqlConnection Get_DB_Connection()
        {
            string cn_String = Properties.Settings.Default.connection_String;
            SqlConnection cn_connection = new SqlConnection(cn_String);
            if (cn_connection.State != System.Data.ConnectionState.Open) cn_connection.Open();

            return cn_connection;
        }

        public static void Close_DB_Connection()
        {
            string cn_String = Properties.Settings.Default.connection_String;
            SqlConnection cn_connection = new SqlConnection(cn_String);
            if (cn_connection.State != ConnectionState.Closed) cn_connection.Close();
        }

        public static DataTable Get_DataTable(string SQL_Text)
        {
            SqlConnection cn_connection = Get_DB_Connection();

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(SQL_Text, cn_connection);
            adapter.Fill(table);

            cn_connection.Close();

            return table;

        }

        public static void Execute_SQL(string SQL_Text)
        {
            SqlConnection cn_connection = Get_DB_Connection();

            SqlCommand cmd_Command = new SqlCommand(SQL_Text, cn_connection);
            cmd_Command.ExecuteNonQuery();

            cn_connection.Close();
        }
        
        

        public static int ReadDataID(string queryString)
        {
            int id = -1;
            using (SqlConnection connection = Get_DB_Connection())
            {
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            id = reader.GetInt32(0);

                            reader.Close();

                            
                            
                        }
                    }
                }
            }
            return id;
        }

        
        

        
        

    }
}
