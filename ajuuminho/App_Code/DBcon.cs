using System.Data;
using System.Data.SqlClient;

namespace ajuUminho.App_Code
{// coisas novas v2
    public abstract class DBcon
    {
        public SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        public SqlCommand cmd = new SqlCommand();
        public SqlDataAdapter sda = new SqlDataAdapter();
        public DataTable dt = new DataTable();
    }
}

