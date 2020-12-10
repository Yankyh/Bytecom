using System;
using System.Collections.Generic;
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
            int proximoId = 0;


            return proximoId;
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
