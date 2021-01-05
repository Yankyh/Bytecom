using Bytecom.Tecnologia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bytecom.Pedido
{
    public partial class ItemPedido : Form
    {
        readonly List<Campo> campo;
        private static int idRegistro;

        public static int IdRegistro { get => idRegistro; set => idRegistro = value; }

        public ItemPedido(int id, int pedido)
        {
            InitializeComponent();
            campo = Campo();
            IdRegistro = id;

            id_Pedido_Venda.Text = pedido.ToString();

            if (idRegistro != 0)
            {
                CarregarFormulario();

                AtualizarPermissoesFormulario();
            }
        }

        private List<Campo> Campo()
        {
            List<Campo> campo = new List<Campo>
            {
                new Campo("Código", "ID", "Int", false),
                new Campo("Pedido Venda", "ID_PEDIDO_VENDA", "Int", true),
                new Campo("Produto", "ID_PRODUTO", "Int", true, "PRODUTO"),
                new Campo("Valor custo", "VALOR_CUSTO", "Float", true),
                new Campo("Valor venda", "VALOR_VENDA", "Float", true),
                new Campo("Quantidade", "QUANTIDADE", "Float", true),
                new Campo("Valor Total", "VALOR_TOTAL", "Float", true),
                new Campo("Data de cadastro", "DATA_CADASTRO", "Datetime", false),
                new Campo("Data de atualização", "DATA_ATUALIZACAO", "Datetime", false)
            };

            return campo;
        }

        private void CarregarFormulario()
        {
            ProdutoOnDropDown(null, null);
            Registro.Selecionar(campo, this, GetTabela(), IdRegistro);
        }
        private void GravarOnClick(object sender, EventArgs e)
        {
            if (ValidarPreenchimento())
            {
                if (idRegistro == 0)
                {
                    Auditoria();

                    idRegistro = Registro.ProximoId(GetTabela());

                    id.Text = idRegistro.ToString();

                    Registro.Gravar(campo, this, GetTabela());
                }
                else
                {
                    Auditoria();
                    Registro.Atualizar(campo, this, GetTabela(), idRegistro);
                }

                AtualizarPermissoesFormulario();
            }
        }

        //Criei um método separado, para caso eu queria adicionar campos dependendo da regra de negócio.
        private Boolean ValidarPreenchimento()
        {
            return Validar.ValidarPreenchimento(campo, this);
        }

        public static String GetTabela()
        {
            return "ITEMPEDIDOVENDA";
        }

        private void Auditoria()
        {
            if (idRegistro == 0)
            {
                data_Cadastro.Value = DateTime.Now;
                data_Atualizacao.Value = DateTime.Now;
            }
            else
            {
                data_Atualizacao.Value = DateTime.Now;
            }

        }

        private void RemoverButtonOnClick(object sender, EventArgs e)
        {
            Registro.Deletar(GetTabela(), Convert.ToInt32(id.Text));
            this.Close();
        }

        private void AtualizarPermissoesFormulario()
        {
            if (idRegistro != 0)
            {
                removerButton.Visible = true;
            }
        }

        private void ProdutoOnDropDown(object sender, EventArgs e)
        {
            Registro.SelecionarComboBox(id_produto, "PRODUTO", "", "NOME");
        }

        private void ProdutoOnSelectedIndexChanged(object sender, EventArgs e)
        {
                String consulta = " SELECT A.ID, " +
                                  "        A.VALOR_CUSTO," +
                                  "        A.VALOR_VENDA " +
                                  "   FROM PRODUTO A " +
                                  "  WHERE A.ID = " + id_produto.SelectedValue;

                foreach (DataRow row in Registro.SelecionarPersonalizado(consulta).Rows)
                {
                    if (row["id"] != DBNull.Value)
                    {
                        valor_Custo.Text = row["VALOR_CUSTO"].ToString();
                        valor_Venda.Text = row["VALOR_VENDA"].ToString();
                    }
                }            
        }

        private void QuantidadeOnTextChanged(object sender, EventArgs e)
        {
            quantidade.Text = Validar.FormatarCampoValor(quantidade);

            if ((Double.TryParse(quantidade.Text, out double valor) && (Double.TryParse(valor_Venda.Text, out double valor2))))
            {
                valor_Total.Text = (float.Parse(quantidade.Text) * float.Parse(valor_Venda.Text)).ToString();
            }
        }

        private void ValorVendaOnLeave(object sender, EventArgs e)
        {
             valor_Venda.Text = Validar.FormatarCampoValor(valor_Venda);
        }

        private void QuantidadeOnLeave(object sender, EventArgs e)
        {
             quantidade.Text = Validar.FormatarCampoValor(quantidade);
        }

        private void ValorVendaOnTextChanged(object sender, EventArgs e)
        {
            valor_Venda.Text = Validar.FormatarCampoValor(valor_Venda);

            if ((Double.TryParse(quantidade.Text, out double valor) && (Double.TryParse(valor_Venda.Text, out double valor2))))
            {
                valor_Total.Text = (float.Parse(quantidade.Text) * float.Parse(valor_Venda.Text)).ToString();
            }
        }

        private void ValorTotalOnTextChanged(object sender, EventArgs e)
        {
            valor_Total.Text = Validar.FormatarCampoValor(valor_Total);
        }

        private void ValorCustoOnTextChanged(object sender, EventArgs e)
        {
            valor_Custo.Text = Validar.FormatarCampoValor(valor_Custo);
        }
    }
}
