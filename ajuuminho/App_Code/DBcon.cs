﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ajuUminho.App_Code
{
    public abstract class DBcon //DBcona cona cona sdsd  aaaa
    {
        public SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        public SqlCommand cmd = new SqlCommand();
        public SqlDataAdapter sda = new SqlDataAdapter();
        public DataTable dt = new DataTable();
    }
}

