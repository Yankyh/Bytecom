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
    public partial class PedidoGerencial : Form
    {
        public PedidoGerencial()
        {
            InitializeComponent();
            CarregarGrid();
        }
        private void IncluirButtonOnClick(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido(0);
            pedido.ShowDialog();
        }

        private void AlterarButtonOnClick(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido(Convert.ToInt32(dataGridView.SelectedCells[0].Value));
            pedido.ShowDialog();
        }

        private void CarregarGrid()
        {
            Registro.SelecionarGrid(this.dataGridView, Pedido.GetTabela());
        }

        private void OnFocusActivated(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void RemoverButtonOnClick(object sender, EventArgs e)
        {
            Registro.Deletar(Pedido.GetTabela(), Convert.ToInt32(dataGridView.SelectedCells[0].Value));
            CarregarGrid();
        }

        private void OnDoubleClick(object sender, MouseEventArgs e)
        {
            Pedido pedido = new Pedido(Convert.ToInt32(dataGridView.SelectedCells[0].Value));
            pedido.ShowDialog();
        }
    }
}
