using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ajuUminho.Ws;
using ajuUminho.App_Code;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace ajuUminho.controls.entidades
{
    public partial class i22RepresentanteLegal : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ListBoxEntidadesID.Items.Add(new ListItem("Escolher Representante Legal", ""));
            //ListBoxEntidadesID.AppendDataBoundItems = true;
            c23EditarRepresentanteLegal ws = new c23EditarRepresentanteLegal();
            DataTable dt = ws.listarRepresentantesLegais();
            ListBoxEntidadesID.DataSource = dt;
            ListBoxEntidadesID.DataTextField = "nome";
            ListBoxEntidadesID.DataValueField = "cc";
            ListBoxEntidadesID.DataBind();
            dt.AsEnumerable().Select(
                row => dt.Columns.Cast<DataColumn>().ToDictionary(
                    column => column.ColumnName,
                    column => row[column] as string)
                    );
            
        }

        protected void ButtonCriarID_Click(object sender, EventArgs e)
        {
            d21RepresentanteLegal rl = new d21RepresentanteLegal();
            rl.guardar(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);
            string mystring = "Representante Legal criado com sucesso.";
            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "Sucesso", "alert('" + mystring + "');", true);
            foreach (TextBox textbox in this.Controls.OfType<TextBox>())
            {
                textbox.Text = string.Empty;
            }
            //s.criarRepresentanteLegal(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
            //   TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
            //   TextBoxNifID.Text, TextBoxLastChangedID.Text);
        }

        protected void ListBoxEntidadesID_SelectedIndexChanged(object sender, EventArgs e)
        {
            c23EditarRepresentanteLegal ws = new c23EditarRepresentanteLegal();
            var getRL = ListBoxEntidadesID.DataValueField;
            var rl = ws.getRepresentanteLegal(getRL);
            TextBoxNomeID.Text = rl.Nome;
            TextBoxMoradaID.Text = rl.Morada;
            TextBoxCodPostalID.Text = rl.CodPostal;
            TextBoxLocalidadeID.Text = rl.Localidade;
            TextBoxEmailID.Text = rl.Email;
            TextBoxTelefoneID.Text = rl.Telefone;
            TextBoxTelemovelID.Text = rl.Telemovel;
            TextBoxFaxID.Text = rl.Fax;
            TextBoxCcID.Text = rl.Cc;
            TextBoxIbanID.Text = rl.Iban;
        }

        protected void ButtonEditarID_Click(object sender, EventArgs e)
        {
            c23EditarRepresentanteLegal ws = new c23EditarRepresentanteLegal();
            ws.editarRepresentanteLegal(TextBoxNomeID.Text, TextBoxMoradaID.Text, TextBoxCodPostalID.Text, TextBoxLocalidadeID.Text,
                TextBoxEmailID.Text, TextBoxTelefoneID.Text, TextBoxTelemovelID.Text, TextBoxFaxID.Text, TextBoxCcID.Text, TextBoxIbanID.Text,
                TextBoxNifID.Text, TextBoxLastChangedID.Text);
        }
    }
}