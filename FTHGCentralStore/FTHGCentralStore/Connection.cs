using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTHGCentralStore
{
    class Connection
    {
        public string path = Path.GetFullPath(Environment.CurrentDirectory);
        private string dbName = "CentralStoreDB.mdf";
        public SqlConnection conn;
        public SqlCommand cmd;
        public SqlDataAdapter adp;
        public string errorText;

        public void connection() 
        {
            conn = new SqlConnection(@"Data Source=KABASH;Initial Catalog=central;Integrated Security=True");
            conn.Open();
             
        }

        public void sendData(String sqlQuery) 
        {
            try
            {
                connection();
                cmd = new SqlCommand(sqlQuery, conn);
                cmd.ExecuteNonQuery();
                errorText = "";
            }
            catch (Exception ex)
            {
                errorText = ex.ToString();
            }
            conn.Close();
        }

        public void getData(String sqlQuery)
        {
            try
            {
                connection();
                adp = new SqlDataAdapter(sqlQuery, conn);
            }
            catch (Exception ex)
            {
                errorText = ex.ToString();
            }
            conn.Close();
        }
    }
}
