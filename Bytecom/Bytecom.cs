using Bytecom.Administracao;
using Bytecom.Pedido;
using Bytecom.Tecnologia.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bytecom
{
    public partial class Bytecom : Form
    {
        public Bytecom()
        {
            InitializeComponent();
            Conexao.Conectar();
        }

        private void PessoaButtonOnClick(object sender, EventArgs e)
        {
            PessoaGerencial pessoaGerencial = new PessoaGerencial();
            pessoaGerencial.ShowDialog();
        }

        private void ProdutoButtonOnClick(object sender, EventArgs e)
        {
            ProdutoGerencial produtoGerencial = new ProdutoGerencial();
            produtoGerencial.ShowDialog();
        }

        private void PedidoButtonOnClick(object sender, EventArgs e)
        {
            PedidoGerencial pedidoGerencial = new PedidoGerencial();
            pedidoGerencial.ShowDialog();
        }
    }
}
