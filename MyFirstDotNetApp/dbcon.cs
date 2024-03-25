using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MyFirstDotNetApp
{
    public class dbcon
    {
        SqlConnection con;

        public dbcon(string connectionstring)
        {
            connection(connectionstring);
        }

        public void connection(string connectionstring)
        {
            con = new SqlConnection(connectionstring);
        }
                
        public bool UDI(string query, Dictionary<string, object> parameters)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);

            foreach (var parameter in parameters)
            {
                cmd.Parameters.AddWithValue(parameter.Key, parameter.Value);
            }

            bool check = cmd.ExecuteNonQuery() > 0;
            con.Close();
            return check;
        }

        public DataTable search(string query)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
