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
                if (campo.Contains(campo.Find(x => x.Obrigatorio && x.NomeFisico.ToUpper() == item.Name.ToUpper() && String.IsNullOrWhiteSpace(item.Text))))
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

        public static String FormatarCampoCNPJCPF(TextBox textBox)
        {
            String conteudo = textBox.Text;

            //Deixar somente númerico.
            conteudo = new string(conteudo.Where(char.IsDigit).ToArray());

            if (conteudo.Length == 11)
            {
                return Convert.ToUInt64(conteudo).ToString(@"000\.000\.000\-00");
            }
            else
            {
                if (conteudo.Length == 14)
                {
                    return Convert.ToUInt64(conteudo).ToString(@"00\.000\.000\/0000\-00");
                }
                else
                {
                    return textBox.Text;
                }
            }
        }

        public static String FormatarCampoTelefone(TextBox textBox)
        {
            String conteudo = textBox.Text;

            //Deixar somente númerico.
            conteudo = new string(conteudo.Where(char.IsDigit).ToArray());

            if (conteudo.Length == 10)
            {
                return Convert.ToUInt64(conteudo).ToString(@"(00)0000\-0000");
            }
            else
            {
                return textBox.Text;
            }
        }

        public static String FormatarCampoCelular(TextBox textBox)
        {
            String conteudo = textBox.Text;

            //Deixar somente númerico.
            conteudo = new string(conteudo.Where(char.IsDigit).ToArray());

            if (conteudo.Length == 11)
            {
                return Convert.ToUInt64(conteudo).ToString(@"(00)00000\-0000");
            }
            else
            {
                return textBox.Text;
            }
        }

        public static String FormatarCampoCep(TextBox textBox)
        {
            String conteudo = textBox.Text;

            //Deixar somente númerico.
            conteudo = new string(conteudo.Where(char.IsDigit).ToArray());

            if (conteudo.Length == 8)
            {
                return Convert.ToUInt64(conteudo).ToString(@"00000\-000");
            }
            else
            {
                return textBox.Text;
            }
        }
    }
}
