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

namespace Bytecom.Administracao
{
    public partial class Produto : Form
    {
        readonly List<Campo> campo;
        private static int idRegistro;

        public static int IdRegistro { get => idRegistro; set => idRegistro = value; }

        public Produto(int id)
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

        private List<Campo> Campo()
        {
            List<Campo> campo = new List<Campo>
            {
                new Campo("Código", "ID", "Int", false),
                new Campo("Nome", "NOME", "String", true),
                new Campo("Código de barras", "CODIGO_BARRAS", "String", true),
                new Campo("Descrição", "DESCRICAO", "String", true),
                new Campo("Valor de custo", "VALOR_CUSTO", "Float", true),
                new Campo("Valor de venda", "VALOR_VENDA", "Float", true),
                new Campo("Data de cadastro", "DATA_CADASTRO", "Datetime", false),
                new Campo("Data de atualização", "DATA_ATUALIZACAO", "Datetime", false),
                new Campo("Data da última venda", "DATA_ULTIMA_VENDA", "Datetime", false)
            };

            return campo;
        }

        private void CarregarFormulario()
        {
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
            return "PRODUTO";
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

        private void ValorCustoOnLeave(object sender, EventArgs e)
        {
            valor_custo.Text = Validar.FormatarCampoValor(valor_custo);
        }

        private void ValorVendaOnLeave(object sender, EventArgs e)
        {
            valor_venda.Text = Validar.FormatarCampoValor(valor_venda);
        }
    }
}

