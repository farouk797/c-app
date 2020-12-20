using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace data
{
    public class Dbconnection
    {
        public MySqlConnection con = new MySqlConnection("server=localhost; User Id=root; password = ; database=tp4");
        public MySqlConnection getcon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }
            return con;
        }
        public int ExeNonQuery(MySqlCommand cmd )
        {
            cmd.Connection = getcon();
            int rowsaffected = -1;
           rowsaffected = cmd.ExecuteNonQuery();
            con.Close ();
            return rowsaffected;

        }
        public DataTable ExeReader(MySqlCommand cmd)
        {
            cmd.Connection = getcon();
            MySqlDataReader sdr;
            DataTable dt = new DataTable();
            sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            return dt;

                
        }
    }
}
