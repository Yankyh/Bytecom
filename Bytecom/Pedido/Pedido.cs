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

                AtualizarPermissoesFormulario();

            }
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
                new Campo("Valor produto", "VALOR_PRODUTO", "Float", true),
                new Campo("Valor desconto", "VALOR_DESCONTO", "Float", false),
                new Campo("Valor total", "VALOR_TOTAL", "Float", true),
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
            }
        }

        //Criei um método separado, para caso eu queria adicionar campos dependendo da regra de negócio.
        private Boolean ValidarPreenchimento()
        {
            return Validar.ValidarPreenchimento(campo, this);
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

        private void ClienteOnDropDown(object sender, EventArgs e)
        {
            Registro.SelecionarComboBox(id_cliente, "PESSOA", "", "NOME");
        }

        private void AdicionarItemButtonOnClick(object sender, EventArgs e)
        {
            ItemPedido itemPedido = new ItemPedido(0, idRegistro);
            itemPedido.ShowDialog();
        }
    }
}
