﻿using System;
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
        }

        private void incluirButtonOnClick(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa(0);
            pessoa.Show();
        }
    }
}