using Bytecom.Tecnologia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bytecom.Pedido
{
    public partial class Pedido : Form
    {
        public Pedido(int id)
        {
            InitializeComponent();

            campo = Campo();
            IdRegistro = id;

            if (idRegistro != 0)
            {
                CarregarFormulario();
            }

            AtualizarPermissoesFormulario();
        }

        readonly List<Campo> campo;
        private static int idRegistro;

        public static int IdRegistro { get => idRegistro; set => idRegistro = value; }

        private List<Campo> Campo()
        {
            List<Campo> campo = new List<Campo>
            {
                new Campo("Código", "ID", "Int", false),
                new Campo("Cliente", "ID_CLIENTE", "Int", true, "PESSOA"),
                new Campo("Data de emissão", "DATA_EMISSAO", "Datetime", true),
                new Campo("Valor produto", "VALOR_PRODUTO", "Float", false),
                new Campo("Valor desconto", "VALOR_DESCONTO", "Float", false),
                new Campo("Valor total", "VALOR_TOTAL", "Float", false),
                new Campo("Valor líquido", "VALOR_LIQUIDO", "Float", false),
                new Campo("Observação", "OBSERVACAO", "String", true), 
                new Campo("Data de cadastro", "DATA_CADASTRO", "Datetime", false),
                new Campo("Data de atualização", "DATA_ATUALIZACAO", "Datetime", false)
            };

            return campo;
        }

        private void CarregarFormulario()
        {
            Registro.Selecionar(campo, this, GetTabela(), IdRegistro);
            Registro.SelecionarSubTabela(itemDataGridView, "ITEMPEDIDOVENDA", "ID_PEDIDO_VENDA", idRegistro);

            ClienteOnDropDown(null, null);
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
                AtualizarProduto();
                AtualizarCliente();
            }
        }

        //Criei um método separado, para caso eu queria adicionar campos dependendo da regra de negócio.
        private Boolean ValidarPreenchimento()
        {
            return Validar.ValidarPreenchimento(campo, this);
        }

        private void AtualizarProduto()
        {
            //Não implementado / Atualizar ultima venda
        }

        private void AtualizarCliente()
        {
            //Não implementado / Atualizar ultima venda
        }

        public static String GetTabela()
        {
            return "PEDIDOVENDA";
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
            //Deve também remover os itens vinculados ao pedido, mas ainda não está implementado.
            Registro.Deletar(GetTabela(), Convert.ToInt32(id.Text));
            this.Close();
        }

        private void AtualizarPermissoesFormulario()
        {
            if (idRegistro != 0)
            {
                removerButton.Visible = true;
                incluirItem.Enabled = true;
            }
            else
            {
                incluirItem.Enabled = false;
            }
        }

        private void ClienteOnDropDown(object sender, EventArgs e)
        {
            Registro.SelecionarComboBox(id_cliente, "PESSOA", "", "NOME");
        }

        private void AdicionarItemButtonOnClick(object sender, EventArgs e)
        {
            ItemPedido itemPedido = new ItemPedido(0, idRegistro);
            itemPedido.ShowDialog();
        }

        private void ValorProdutoOnTextChanged(object sender, EventArgs e)
        {
            valor_produto.Text = Validar.FormatarCampoValor(valor_produto);
        }

        private void ValorTotalOnTextChanged(object sender, EventArgs e)
        {
            valor_total.Text = Validar.FormatarCampoValor(valor_total);
        }

        private void ProdutoGridOnDoubleClick(object sender, EventArgs e)
        {
            ItemPedido itemPedido = new ItemPedido(Convert.ToInt32(itemDataGridView.SelectedCells[0].Value), IdRegistro);
            itemPedido.ShowDialog();
        }

        private void ExcluirItemButtonOnClick(object sender, EventArgs e)
        {
            //Não implementado
        }

        private void OnFocusActivated(object sender, EventArgs e)
        {
            Registro.SelecionarSubTabela(itemDataGridView, "ITEMPEDIDOVENDA", "ID_PEDIDO_VENDA", idRegistro);
        }

        private void ValorLiquidoOnTextChanged(object sender, EventArgs e)
        {
            valor_liquido.Text = Validar.FormatarCampoValor(valor_liquido);
        }

        private void ValorDescontoOnLeave(object sender, EventArgs e)
        {
            valor_desconto.Text = Validar.FormatarCampoValor(valor_desconto);

            String consulta = " SELECT A.VALOR_TOTAL " +
                              "   FROM PEDIDOVENDA A " +
                              "  WHERE A.ID = " + idRegistro;

            foreach (DataRow row in Registro.SelecionarPersonalizado(consulta).Rows)
            {
                if (row["VALOR_TOTAL"] != DBNull.Value)
                {
                    valor_liquido.Text = (Convert.ToDouble(row["VALOR_TOTAL"]) - Convert.ToDouble(valor_desconto.Text)).ToString();
                }
            }
        }
    }
}
