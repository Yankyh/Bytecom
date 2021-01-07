
namespace Bytecom.Administracao
{
    partial class Pessoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nome = new System.Windows.Forms.TextBox();
            this.cpf_Cnpj = new System.Windows.Forms.TextBox();
            this.telefone = new System.Windows.Forms.TextBox();
            this.endereco = new System.Windows.Forms.TextBox();
            this.bairro = new System.Windows.Forms.TextBox();
            this.complemento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.celular = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.removerButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cidade = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cep = new System.Windows.Forms.TextBox();
            this.data_Atualizacao = new System.Windows.Forms.DateTimePicker();
            this.data_Cadastro = new System.Windows.Forms.DateTimePicker();
            this.data_Ultima_Venda = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(21, 38);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(260, 20);
            this.nome.TabIndex = 0;
            // 
            // cpf_Cnpj
            // 
            this.cpf_Cnpj.Location = new System.Drawing.Point(288, 38);
            this.cpf_Cnpj.MaxLength = 20;
            this.cpf_Cnpj.Name = "cpf_Cnpj";
            this.cpf_Cnpj.Size = new System.Drawing.Size(154, 20);
            this.cpf_Cnpj.TabIndex = 1;
            this.cpf_Cnpj.Leave += new System.EventHandler(this.CPFCNPJOnLeave);
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(448, 38);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(113, 20);
            this.telefone.TabIndex = 2;
            this.telefone.Leave += new System.EventHandler(this.TelefoneOnLeave);
            // 
            // endereco
            // 
            this.endereco.Location = new System.Drawing.Point(434, 91);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(354, 20);
            this.endereco.TabIndex = 7;
            // 
            // bairro
            // 
            this.bairro.Location = new System.Drawing.Point(24, 151);
            this.bairro.Name = "bairro";
            this.bairro.Size = new System.Drawing.Size(199, 20);
            this.bairro.TabIndex = 8;
            // 
            // complemento
            // 
            this.complemento.Location = new System.Drawing.Point(229, 151);
            this.complemento.Name = "complemento";
            this.complemento.Size = new System.Drawing.Size(559, 20);
            this.complemento.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "CPF/CNPJ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(564, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Celular";
            // 
            // celular
            // 
            this.celular.Location = new System.Drawing.Point(567, 38);
            this.celular.Name = "celular";
            this.celular.Size = new System.Drawing.Size(113, 20);
            this.celular.TabIndex = 4;
            this.celular.Leave += new System.EventHandler(this.CelularOnLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Endereco";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Bairro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Complemento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Data de cadastro";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(168, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Data de atualização";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(318, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Última venda";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(684, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Código";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(687, 38);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(101, 20);
            this.id.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Gravar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GravarOnClick);
            // 
            // removerButton
            // 
            this.removerButton.Location = new System.Drawing.Point(632, 351);
            this.removerButton.Name = "removerButton";
            this.removerButton.Size = new System.Drawing.Size(75, 23);
            this.removerButton.TabIndex = 25;
            this.removerButton.Text = "Excluir";
            this.removerButton.UseVisualStyleBackColor = true;
            this.removerButton.Visible = false;
            this.removerButton.Click += new System.EventHandler(this.RemoverButtonOnClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Cidade";
            // 
            // cidade
            // 
            this.cidade.Location = new System.Drawing.Point(24, 91);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(199, 20);
            this.cidade.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(226, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Cep";
            // 
            // cep
            // 
            this.cep.Location = new System.Drawing.Point(229, 91);
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(199, 20);
            this.cep.TabIndex = 6;
            this.cep.Leave += new System.EventHandler(this.CepOnLeave);
            // 
            // data_Atualizacao
            // 
            this.data_Atualizacao.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.data_Atualizacao.Enabled = false;
            this.data_Atualizacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_Atualizacao.Location = new System.Drawing.Point(171, 354);
            this.data_Atualizacao.Name = "data_Atualizacao";
            this.data_Atualizacao.Size = new System.Drawing.Size(144, 20);
            this.data_Atualizacao.TabIndex = 65;
            this.data_Atualizacao.Value = new System.DateTime(1899, 1, 1, 12, 0, 0, 0);
            // 
            // data_Cadastro
            // 
            this.data_Cadastro.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.data_Cadastro.Enabled = false;
            this.data_Cadastro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_Cadastro.Location = new System.Drawing.Point(21, 354);
            this.data_Cadastro.Name = "data_Cadastro";
            this.data_Cadastro.Size = new System.Drawing.Size(144, 20);
            this.data_Cadastro.TabIndex = 66;
            this.data_Cadastro.Value = new System.DateTime(1899, 1, 1, 12, 0, 0, 0);
            // 
            // data_Ultima_Venda
            // 
            this.data_Ultima_Venda.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.data_Ultima_Venda.Enabled = false;
            this.data_Ultima_Venda.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_Ultima_Venda.Location = new System.Drawing.Point(321, 354);
            this.data_Ultima_Venda.Name = "data_Ultima_Venda";
            this.data_Ultima_Venda.Size = new System.Drawing.Size(144, 20);
            this.data_Ultima_Venda.TabIndex = 67;
            this.data_Ultima_Venda.Value = new System.DateTime(1899, 1, 1, 12, 0, 0, 0);
            // 
            // Pessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 386);
            this.Controls.Add(this.data_Ultima_Venda);
            this.Controls.Add(this.data_Cadastro);
            this.Controls.Add(this.data_Atualizacao);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cep);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cidade);
            this.Controls.Add(this.removerButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.celular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.complemento);
            this.Controls.Add(this.bairro);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.cpf_Cnpj);
            this.Controls.Add(this.nome);
            this.Name = "Pessoa";
            this.Text = "Pessoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox cpf_Cnpj;
        private System.Windows.Forms.TextBox telefone;
        private System.Windows.Forms.TextBox endereco;
        private System.Windows.Forms.TextBox bairro;
        private System.Windows.Forms.TextBox complemento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox celular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button removerButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox cep;
        private System.Windows.Forms.DateTimePicker data_Atualizacao;
        private System.Windows.Forms.DateTimePicker data_Cadastro;
        private System.Windows.Forms.DateTimePicker data_Ultima_Venda;
    }
}