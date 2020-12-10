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
        readonly Conexao conexao = new Conexao();

        public int ProximoId(String tabela)
        {
            int proximoId = 0;

            foreach (DataRow row in conexao.ExecutaConsulta("SELECT MAX(ID) FROM " + tabela).Rows)
            {
                return proximoId = (int)(row["id"]);
            }

            return 0;
        }
        public static int Gravar(List<Campo> campo, Form form, String tabela)
        {
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
                    if ((campoAtual.Tipo == "String") || (campoAtual.Tipo == "Datetime"))
                    {
                        insert = insert  + "\"" + item.Text + "\", ";
                    }
                    else
                    {
                        insert = insert + item.Text + ",";
                    }
                    
                }
            }

            insert = insert.TrimEnd(' ').TrimEnd(',') + ")";

            MessageBox.Show(insert);
            return id;
        }
    }
}
