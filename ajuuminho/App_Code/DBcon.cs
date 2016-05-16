using System.Data;
using System.Data.SqlClient;

namespace ajuUminho.App_Code
{
    public class DBcon // teste no desktop de casa do oscar xD
    {
        //asda

        public SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        public SqlCommand cmd = new SqlCommand();
        public SqlDataAdapter sda = new SqlDataAdapter();
        public DataTable dt = new DataTable();
    }
}

