using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ajuUminho.App_Code;
using System.Data;

namespace ajuUminho.Ws
{
    /// <summary>
    /// Summary description for c23EditarRepresentanteLegal
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class c23EditarRepresentanteLegal : System.Web.Services.WebService
    {

        public void editarRepresentanteLegal(RepresentanteLegalDTO rldto)
        {
            // efetuar controlos
            var id = rldto.getID(rldto.Cc);
            if (rldto.ccUnique(rldto.Cc, id) == true)
            {
                rldto.SetRepresentanteLegal(rldto, id);
            }
            
        }

        public void criarRepresentanteLegal (string nome, string morada, string codPostal, string localidade, string email,
            string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy)
        {
            d21RepresentanteLegal rl = new d21RepresentanteLegal(nome, morada, codPostal, localidade, email, telefone, telemovel, fax, cc, iban, nif, lastChangeBy);

        }

        public DataTable listarRepresentantesLegais()
        {
            d21RepresentanteLegal rl = new d21RepresentanteLegal();
            DataTable dt = rl.getListaRepresentantesLegais();
            return dt;
        }

        public void removerRepresentanteLegal(string id)
        {
            // efetuar controlos
            d21RepresentanteLegal rl = new d21RepresentanteLegal();
            rl.removeRepresentanteLegal(id);
        }

    }
}
