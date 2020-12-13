using Bytecom.Tecnologia;
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

namespace Bytecom.Administracao
{
    public partial class PessoaGerencial : Form
    {
        public PessoaGerencial()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void IncluirButtonOnClick(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa(0);
            pessoa.ShowDialog();
        }

        private void AlterarButtonOnClick(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa(Convert.ToInt32(dataGridView.SelectedCells[0].Value));
            pessoa.ShowDialog();
        }

        private void CarregarGrid()
        {
            Registro.SelecionarGrid(this.dataGridView, Pessoa.GetTabela());
        }

        private void OnFocusActivated(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void RemoverButtonOnClick(object sender, EventArgs e)
        {
            Registro.Deletar(Pessoa.GetTabela(), Convert.ToInt32(dataGridView.SelectedCells[0].Value));
            CarregarGrid();
        }

        private void OnDoubleClick(object sender, MouseEventArgs e)
        {
            Pessoa pessoa = new Pessoa(Convert.ToInt32(dataGridView.SelectedCells[0].Value));
            pessoa.ShowDialog();
        }
    }
}
