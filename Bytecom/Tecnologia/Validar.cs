using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bytecom.Tecnologia
{
    class Validar
    {
        public static Boolean ValidarPreenchimento(List<Campo> campo, Form form)
        {
            foreach (Control item in form.Controls)
            {
                if (campo.Contains(campo.Find(x => x.Obrigatorio && x.NomeFisico.ToUpper() == item.Name.ToUpper() && String.IsNullOrWhiteSpace(item.Text))) )
                {
                    MessageBox.Show("O campo " + campo.Find(x => x.NomeFisico.ToUpper() == item.Name.ToUpper()).Nome + " é de preenchimento obrigatório!", "Campo inválido!");

                    return false;
                }

            }

            return true;
        }

        public static String FormatarCampoValor(TextBox textBox)
        {
            Double valor;
            if (Double.TryParse(textBox.Text, out valor))
                return textBox.Text = String.Format("{0:0.00}", valor);
            else
                return textBox.Text = String.Empty;
        }
    }
}
