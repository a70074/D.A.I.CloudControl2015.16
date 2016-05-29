using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ajuUminho.Ws;

namespace ajuUminho.controls.utilizadores
{
    public partial class i12AutenticacaoDeUtilizadores : System.Web.UI.UserControl
    {
        protected void SignIn(object sender, EventArgs e)
        {
            gestaoIdentidade ws1 = new gestaoIdentidade();
            if (ws1.signIn(TextBoxUserNameID.Text, TextBoxPasswordID.Text) == true)
            {
                Response.Redirect("~/webforms/home.aspx");
            }
            else
            {
                //StatusText.Text = "Invalid username or password.";
                //LoginStatus.Visible = true;
            }

        }

    }
}