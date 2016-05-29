using ajuUminho.App_Code;
using System.Collections.Generic;
using System.Web.Services;
using System.Data;
using System;

namespace ajuUminho.Ws
{
    /// <summary>
 /*   /// Summary description for ControloDeEntidades
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
   /* public class ControloDeEntidades : System.Web.Services.WebService
    {

        [WebMethod]
        public IList<string> getEntidade(String id, string tipoEntidade)
        {
            Entidade ent = new Entidade();
            Entidade ents = ent.getEntidade(id, tipoEntidade, ent);
            IList<string> lista = new List<string>();
            lista.Add(ents.Nome);
            lista.Add(ents.Morada);
            lista.Add(ents.CodPostal);
            lista.Add(ents.Localidade);
            lista.Add(ents.Email);
            lista.Add(ents.Telefone);
            lista.Add(ents.Telemovel);
            lista.Add(ents.Fax);
            lista.Add(ents.Cc);
            lista.Add(ents.Iban);
            lista.Add(ents.Nif);
            lista.Add(ents.LastChangeBy);
            return lista;

        }

        [WebMethod]
        public Dictionary<String, String> getListaEntidade(string tipoEntidade)
        {
            Entidade ent = new Entidade();
            DataTable dt = ent.getListaEntidade(tipoEntidade);
            Dictionary <String, String> lista = new Dictionary<String, String>();
            for (int i = 0; i < dt.Rows.Count; i++) {
                lista.Add(Convert.ToString(dt.Rows[i]["id"]), Convert.ToString(dt.Rows[i]["nome"]));
            }
            return lista;

        }


        [WebMethod]
        public void setEntidade(string tipoEntidade, string nome, string morada, string codPostal, string localidade, string email, string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy)
        {
            Entidade ent = new Entidade(nome, morada, codPostal, localidade, email, telefone, telemovel, fax, cc, iban, nif, lastChangeBy);
            ent.SetEntidade(ent, tipoEntidade);
        }

        public void editarEntidade(string id, string tipoEntidade, string nome, string morada, string codPostal, string localidade, string email, string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy)
        {
            Entidade ent = new Entidade(nome, morada, codPostal, localidade, email, telefone, telemovel, fax, cc, iban, nif, lastChangeBy);
            ent.editarEntidade(id, ent, tipoEntidade);
        }

        //[WebMethod]
        //private void MakeDataTableAndDisplay()
        //{
        //    // Create new DataTable and DataSource objects.
        //    DataTable table = new DataTable();

        //    // Declare DataColumn and DataRow variables.
        //    DataColumn column;
        //    DataRow row;
        //    DataView view;

        //    // Create new DataColumn, set DataType, ColumnName and add to DataTable.    
        //    column = new DataColumn();
        //    column.DataType = System.Type.GetType("System.Int32");
        //    column.ColumnName = "id";
        //    table.Columns.Add(column);

        //    // Create second column.
        //    column = new DataColumn();
        //    column.DataType = Type.GetType("System.String");
        //    column.ColumnName = "item";
        //    table.Columns.Add(column);

        //    // Create new DataRow objects and add to DataTable.    
        //    for (int i = 0; i < 10; i++)
        //    {
        //        row = table.NewRow();
        //        row["id"] = i;
        //        row["item"] = "item " + i.ToString();
        //        table.Rows.Add(row);
        //    }

        //    // Create a DataView using the DataTable.
        //    view = new DataView(table);

        //    // Set a DataGrid control's DataSource to the DataView.
        //    dataGrid1.DataSource = view;
        //}

    }*/
}
