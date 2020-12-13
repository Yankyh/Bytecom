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

namespace Bytecom.Administracao
{
    public partial class ProdutoGerencial : Form
    {
        public ProdutoGerencial()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void IncluirButtonOnClick(object sender, EventArgs e)
        {
            Produto produto = new Produto(0);
            produto.ShowDialog();
        }

        private void AlterarButtonOnClick(object sender, EventArgs e)
        {
            Produto produto = new Produto(Convert.ToInt32(dataGridView.SelectedCells[0].Value));
            produto.ShowDialog();
        }

        private void CarregarGrid()
        {
            Registro.SelecionarGrid(this.dataGridView, Produto.GetTabela());
        }

        private void OnFocusActivated(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void RemoverButtonOnClick(object sender, EventArgs e)
        {
            Registro.Deletar(Produto.GetTabela(), Convert.ToInt32(dataGridView.SelectedCells[0].Value));
            CarregarGrid();
        }

        private void OnDoubleClick(object sender, MouseEventArgs e)
        {
            Produto produto = new Produto(Convert.ToInt32(dataGridView.SelectedCells[0].Value));
            produto.ShowDialog();
        }
    }
}
