using Bytecom.Tecnologia.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bytecom.Tecnologia
{
    class Registro
    {

        public static int ProximoId(String tabela)
        {
            Conexao conexao = new Conexao();

            foreach (DataRow row in conexao.ExecutaConsulta("SELECT MAX(ID) + 1 id FROM " + tabela).Rows)
            {
                if (row["id"] != DBNull.Value)
                {
                    return _ = (Convert.ToInt32(row["id"]));
                }

            }

            return 1;
        }
        public static int Gravar(List<Campo> campo, Form form, String tabela)
        {
            Conexao conexao = new Conexao();
            int id = 0;
            string insert = "INSERT INTO " + tabela + " (";

            //FIELDS
            foreach (Control item in form.Controls)
            {
                if (campo.Contains(campo.Find(x => x.NomeFisico.ToUpper() == item.Name.ToUpper())))
                {
                    insert = insert + campo.Find(x => x.NomeFisico.ToUpper() == item.Name.ToUpper()).NomeFisico + ", ";
                }

            }

            insert = insert.TrimEnd(' ').TrimEnd(',') + ") VALUES (";

            //VALUES
            foreach (Control item in form.Controls)
            {
                Campo campoAtual = campo.Find(x => x.NomeFisico.ToUpper() == item.Name.ToUpper());

                if (campo.Contains(campoAtual))
                {
                    if (String.IsNullOrWhiteSpace(item.Text))
                    {
                        insert = insert + " null, ";
                    }
                    else
                    {
                        if ((campoAtual.Tipo == "String") || (campoAtual.Tipo == "Datetime"))
                        {
                            insert = insert + "'" + item.Text + "', ";
                        }
                        else
                        {
                            insert = insert + item.Text + ",";
                        }
                    }

                }
            }

            insert = insert.TrimEnd(' ').TrimEnd(',') + ")";
            conexao.ExecutarDML(insert);

            return id;
        }

        public static void Atualizar(List<Campo> campo, Form form, String tabela, int id)
        {
            Conexao conexao = new Conexao();

            string update = "UPDATE " + tabela + " SET ";

            //FIELDS
            foreach (Control item in form.Controls)
            {
                Campo campoAtual = campo.Find(x => (x.NomeFisico.ToUpper() == item.Name.ToUpper()) && x.NomeFisico.ToUpper() != "ID");

                if (campo.Contains(campoAtual))
                {
                    update = update + campoAtual.NomeFisico + " = ";

                    if (String.IsNullOrWhiteSpace(item.Text))
                    {
                        update = update + " null, ";
                    }
                    else
                    {
                        if ((campoAtual.Tipo == "String") || (campoAtual.Tipo == "Datetime"))
                        {
                            update = update + "'" + item.Text + "', ";
                        }
                        else
                        {
                            update = update + item.Text + ", ";
                        }
                    }

                }
            }
            update = update.TrimEnd(' ').TrimEnd(',') + "WHERE ID = " + id;
            conexao.ExecutarDML(update);
        }

        public static Form Selecionar(List<Campo> campo, Form form, String tabela, int id)
        {
            Form formRetorno = form;

            Conexao conexao = new Conexao();

            string select = "SELECT * FROM " + tabela + " WHERE ID = " + id;

            foreach (DataRow row in conexao.ExecutaConsulta(select).Rows)
            {
                if (row["id"] != DBNull.Value)
                {
                    foreach (Control item in form.Controls)
                    {
                        Campo campoAtual = campo.Find(x => (x.NomeFisico.ToUpper() == item.Name.ToUpper()));

                        if (campo.Contains(campoAtual))
                        {
                            item.Text = row[campoAtual.NomeFisico].ToString();
                        }
                    }

                }
            }

            return formRetorno;
        }

    }
}

