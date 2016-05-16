using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace ajuUminho.App_Code
{
    public class d21RepresentanteLegal : Entidade
    {

        protected string cc;

        public string Cc
        {
            get
            {
                return cc;
            }

            set
            {
                cc = value;
            }
        }

        public d21RepresentanteLegal() { }

        public d21RepresentanteLegal(string nome, string morada, string codPostal, string localidade, string email, string telefone, string telemovel, string fax, string cc, string iban, string nif, string lastChangeBy)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@morada", morada);
            cmd.Parameters.AddWithValue("@codPostal", codPostal);
            cmd.Parameters.AddWithValue("@localidade", localidade);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@telemovel", telemovel);
            cmd.Parameters.AddWithValue("@fax", fax);
            cmd.Parameters.AddWithValue("@cc", cc);
            cmd.Parameters.AddWithValue("@iban", iban);
            cmd.Parameters.AddWithValue("@nif", nif);
            cmd.Parameters.AddWithValue("@lastChangeBy", lastChangeBy);
            cmd.CommandText = "INSERT INTO dbo.representantelegal VALUES (@nome, @morada, @codPostal, @localidade, @email, @telefone, @telemovel, @fax, @cc, @iban, @nif, @lastChangeBy);";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();

        }


        public DataTable getListaRepresentantesLegais()
        {
            SqlDataReader reader;
            cmd.CommandText = "SELECT * FROM [dbo].[representantelegal];";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.Connection.Open();
            reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            return dataTable;
        }


        public void SetRepresentanteLegal(RepresentanteLegalDTO rldto, string id)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@nome", rldto.nome);
            cmd.Parameters.AddWithValue("@morada", rldto.morada);
            cmd.Parameters.AddWithValue("@codPostal", rldto.codPostal);
            cmd.Parameters.AddWithValue("@localidade", rldto.localidade);
            cmd.Parameters.AddWithValue("@email", rldto.email);
            cmd.Parameters.AddWithValue("@telefone", rldto.telefone);
            cmd.Parameters.AddWithValue("@telemovel", rldto.telemovel);
            cmd.Parameters.AddWithValue("@fax", rldto.fax);
            cmd.Parameters.AddWithValue("@cc", rldto.cc);
            cmd.Parameters.AddWithValue("@iban", rldto.iban);
            cmd.Parameters.AddWithValue("@nif", rldto.nif);
            cmd.Parameters.AddWithValue("@lastChangeBy", rldto.lastChangeBy);
            cmd.CommandText = "UPDATE dbo.representantelegal SET nome = @nome, morada = @morada, codPostal = @codPostal, localidade = @localidade, email = @email, telefone = @telefone, telemovel = @telemovel, fax = @fax, cc = @cc, iban = @iban, nif = @nif WHERE );";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public RepresentanteLegalDTO getRepresentanteLegal(string id)
        {
            RepresentanteLegalDTO rldto = new RepresentanteLegalDTO();
            SqlDataReader reader;
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = "SELECT * FROM dbo.representantelegal WHERE id = '" + id + "'";
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();
            var dataTable = new DataTable();
            dataTable.Load(reader);
            con.Close();
            rldto.Nome = Convert.ToString(dataTable.Rows[1]["nome"]);
            rldto.Morada = (Convert.ToString(dataTable.Rows[1]["morada"]));
            rldto.CodPostal = (Convert.ToString(dataTable.Rows[1]["codPostal"]));
            rldto.Localidade = (Convert.ToString(dataTable.Rows[1]["localidade"]));
            rldto.Email = (Convert.ToString(dataTable.Rows[1]["email"]));
            rldto.Telefone = (Convert.ToString(dataTable.Rows[1]["telefone"]));
            rldto.Telemovel = (Convert.ToString(dataTable.Rows[1]["telemovel"]));
            rldto.Fax = (Convert.ToString(dataTable.Rows[1]["fax"]));
            rldto.Cc = (Convert.ToString(dataTable.Rows[1]["cc"]));
            rldto.Iban = (Convert.ToString(dataTable.Rows[1]["iban"]));
            rldto.Nif = (Convert.ToString(dataTable.Rows[1]["nif"]));
            rldto.LastChangeBy = (Convert.ToString(dataTable.Rows[1]["lastChangeBy"]));
            return rldto;
        }

        public void removeRepresentanteLegal (string id)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = "DELETE FROM dbo.representantelegal WHERE id = @id";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public string getID(string cc)
        {
            con.Open();
            cmd.Parameters.AddWithValue("@cc", cc);
            cmd.CommandText = "SELECT id FROM dbo.representantelegal WHERE cc = @cc";
            cmd.CommandType = CommandType.Text;
            string id = cmd.ExecuteNonQuery().ToString();
            
            con.Close();
            
            
            return id;

        }

        public bool ccUnique (string cc, string id)
        {
            SqlDataReader reader;
            SqlDataReader reader2;
            DataTable dt = new DataTable();
            con.Open();
            cmd.Parameters.AddWithValue("@cc", cc);
            cmd.CommandText = "SELECT * FROM dbo.representantelegal WHERE cc = @cc";
            cmd.CommandType = CommandType.Text;
            reader = cmd.ExecuteReader();
            dt.Load(reader);
            if (dt.Rows.Count == 1)
            {
                cmd.Parameters.AddWithValue("id", id);
                cmd.CommandText = "SELECT * FROM dbo.representantelegal WHERE cc = @cc AND id = @id";
                cmd.CommandType = CommandType.Text;
                reader2 = cmd.ExecuteReader();
                dt.Load(reader2);
                if (dt.Rows.Count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (dt.Rows.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}