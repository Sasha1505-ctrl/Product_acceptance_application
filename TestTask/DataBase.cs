using System.Data.SqlClient;

namespace TestTask
{
    internal class DataBase
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QS6K7L2; Initial Catalog=testdb; Integrated Security=True");
        public void openConnection()
        {
            if(conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return conn;
        }
    }
}
