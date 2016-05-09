using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ajuUminho.Ws;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace ajuUminho.webforms
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if ((string)(Session["userRoles"]) != "Admin")
            //{
            //    Response.Redirect("~/Login.aspx");
            //}
            //Id.Text = HttpContext.Current.Session["userId"].ToString();
            /*ListBox1.Items.Clear();
            var list = Session["userRoles"] as IList<string>;

            for (int i = 0; i < list.Count; i++)
            {
                ListBox2.Items.Add(list[i]);
            }*/
          
        }


    }
}