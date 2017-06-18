using MySql.Data.MySqlClient;
using System.Data;

namespace DataAccess
{
    class Database
    {
        MySqlConnection con;
        MySqlDataAdapter da;
        DataSet ds;
        public Database()
        {
            string sql = "Server=db4free.net;Port=3307;database=qlkho;User Id=khang100;Password=123456;charset=utf8";
            con = new MySqlConnection(sql);
        }

        public bool Execute(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable LoadData(string sql)
        {
            ds = new DataSet();
            da = new MySqlDataAdapter(sql, con);
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}