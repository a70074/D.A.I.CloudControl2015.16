using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ajuUminho.Ws;

namespace ajuUminho.controls.entidades
{
    public partial class i22RepresentanteLegal : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCriarID_Click(object sender, EventArgs e)
        {
            c23EditarRepresentanteLegal ws = new c23EditarRepresentanteLegal();
            ws.criarRepresentanteLegal(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);
        }

        protected void ListBoxEntidadesID_SelectedIndexChanged(object sender, EventArgs e)
        {
            c23EditarRepresentanteLegal ws = new c23EditarRepresentanteLegal();
            ws.listarRepresentantesLegais();
            ListBoxEntidadesID.DataBind();
        }
    }
}