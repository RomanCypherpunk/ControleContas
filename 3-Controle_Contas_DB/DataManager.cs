using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Controle_Contas_DB
{
    public class DataManager
    {
        private string ConectionString = @"Data Source=192.168.20.138;Initial Catalog=FifaManager;User ID=criptomanager;Password=123456;TrustServerCertificate=True";

        private SqlConnection conn = null;
        private SqlDataAdapter adapter = null;
        private SqlCommand cmd = null;

        private void conect()
        {
            conn = new SqlConnection();
            conn.ConnectionString = ConectionString;
            conn.Open();

        }

        public void execute(string query)
        {
            conect();

            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            close();
        }

        public SqlDataReader executeReader(string query)
        {
            conect();

            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;


            SqlDataReader reader = cmd.ExecuteReader();

            return reader;
        }

        public DataTable executeTable(string query)
        {

            conect();

            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            DataTable dt = ds.Tables[0];

            close();

            return dt;

        }


        private void close()
        {
            conn.Close();
            conn = null;
        }
    }
}
