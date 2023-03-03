using System.Configuration;
using System.Data.SqlClient;

namespace SchoolSystemERP
{
    public class MyConnection
    {
        public SqlConnection conn;
        public MyConnection()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CC"].ConnectionString);
        }
        public static string type;
    }
}
