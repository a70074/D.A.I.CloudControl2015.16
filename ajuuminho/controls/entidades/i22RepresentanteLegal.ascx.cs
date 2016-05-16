using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ajuUminho.Ws;
using System.Data;
using System.Data.SqlClient;

namespace ajuUminho.controls.entidades
{
    public partial class i22RepresentanteLegal : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListBoxEntidadesID.Items.Add(new ListItem("Escolher Representante Legal", ""));
            ListBoxEntidadesID.AppendDataBoundItems = true;
            c23EditarRepresentanteLegal ws = new c23EditarRepresentanteLegal();
            DataTable dt = ws.listarRepresentantesLegais();
            ListBoxEntidadesID.DataSource = dt;
            ListBoxEntidadesID.DataTextField = "nome";
            ListBoxEntidadesID.DataValueField = "id";
            ListBoxEntidadesID.DataBind();
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
            ListBoxEntidadesID.Items.Add(new ListItem("Escolher Representante Legal", ""));
            ListBoxEntidadesID.AppendDataBoundItems = true;
            c23EditarRepresentanteLegal ws = new c23EditarRepresentanteLegal();
            DataTable dt = ws.listarRepresentantesLegais();
            ListBoxEntidadesID.DataSource = dt;
            ListBoxEntidadesID.DataTextField = "nome";
            ListBoxEntidadesID.DataValueField = "id";
            ListBoxEntidadesID.DataBind();
            /* c23EditarRepresentanteLegal ws = new c23EditarRepresentanteLegal();
             DataTable dt = ws.listarRepresentantesLegais();
             //SqlDataAdapter sda = new SqlDataAdapter();
             //sda.Fill(dt);
             ListBoxEntidadesID.DataSource = dt;
             ListBoxEntidadesID
            c23EditarRepresentanteLegal ws = new c23EditarRepresentanteLegal();
            var lista = ws.getListaRepresentantesLegais();
                        ListBoxEntidadesID.DataSource = lista;
            foreach (KeyValuePair<String, String> pair in lista)
                 {
                      ListItem Item = new ListItem();
                      Item.Text = pair.Value.ToString();
                      Item.Value = pair.Key.ToString();
                      ListBoxEntidadesID.Items.Add(Item);
                      ListBoxEntidadesID.DataBind();
                 }*/

        }

        protected void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}