
namespace Bytecom.Administracao
{
    partial class Produto
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
            this.removerButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.valor_venda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.valor_custo = new System.Windows.Forms.TextBox();
            this.codigo_barras = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.TextBox();
            this.descricao = new System.Windows.Forms.RichTextBox();
            this.ultima_Venda = new System.Windows.Forms.DateTimePicker();
            this.data_Atualizacao = new System.Windows.Forms.DateTimePicker();
            this.data_Cadastro = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // removerButton
            // 
            this.removerButton.Location = new System.Drawing.Point(629, 340);
            this.removerButton.Name = "removerButton";
            this.removerButton.Size = new System.Drawing.Size(75, 23);
            this.removerButton.TabIndex = 55;
            this.removerButton.Text = "Excluir";
            this.removerButton.UseVisualStyleBackColor = true;
            this.removerButton.Visible = false;
            this.removerButton.Click += new System.EventHandler(this.RemoverButtonOnClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(710, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 54;
            this.button1.Text = "Gravar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GravarOnClick);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(684, 27);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(101, 20);
            this.id.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(681, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Código";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(309, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "Última venda";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(159, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Data de atualização";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Data de cadastro";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(18, 81);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 13);
            this.label23.TabIndex = 46;
            this.label23.Text = "Descrição";
            // 
            // valor_venda
            // 
            this.valor_venda.Location = new System.Drawing.Point(564, 27);
            this.valor_venda.Name = "valor_venda";
            this.valor_venda.Size = new System.Drawing.Size(113, 20);
            this.valor_venda.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Valor venda";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(442, 11);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(60, 13);
            this.label.TabIndex = 42;
            this.label.Text = "Valor custo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Código de barras";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nome";
            // 
            // valor_custo
            // 
            this.valor_custo.Location = new System.Drawing.Point(445, 27);
            this.valor_custo.Name = "valor_custo";
            this.valor_custo.Size = new System.Drawing.Size(113, 20);
            this.valor_custo.TabIndex = 32;
            // 
            // codigo_barras
            // 
            this.codigo_barras.Location = new System.Drawing.Point(285, 27);
            this.codigo_barras.MaxLength = 14;
            this.codigo_barras.Name = "codigo_barras";
            this.codigo_barras.Size = new System.Drawing.Size(154, 20);
            this.codigo_barras.TabIndex = 31;
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(18, 27);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(260, 20);
            this.nome.TabIndex = 30;
            // 
            // descricao
            // 
            this.descricao.Location = new System.Drawing.Point(21, 97);
            this.descricao.MaxLength = 128;
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(764, 96);
            this.descricao.TabIndex = 58;
            this.descricao.Text = "";
            // 
            // ultima_Venda
            // 
            this.ultima_Venda.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.ultima_Venda.Enabled = false;
            this.ultima_Venda.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ultima_Venda.Location = new System.Drawing.Point(312, 354);
            this.ultima_Venda.Name = "ultima_Venda";
            this.ultima_Venda.Size = new System.Drawing.Size(144, 20);
            this.ultima_Venda.TabIndex = 66;
            this.ultima_Venda.Value = new System.DateTime(1899, 1, 1, 12, 0, 0, 0);
            // 
            // data_Atualizacao
            // 
            this.data_Atualizacao.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.data_Atualizacao.Enabled = false;
            this.data_Atualizacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_Atualizacao.Location = new System.Drawing.Point(162, 354);
            this.data_Atualizacao.Name = "data_Atualizacao";
            this.data_Atualizacao.Size = new System.Drawing.Size(144, 20);
            this.data_Atualizacao.TabIndex = 67;
            this.data_Atualizacao.Value = new System.DateTime(1899, 1, 1, 12, 0, 0, 0);
            // 
            // data_Cadastro
            // 
            this.data_Cadastro.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.data_Cadastro.Enabled = false;
            this.data_Cadastro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_Cadastro.Location = new System.Drawing.Point(12, 354);
            this.data_Cadastro.Name = "data_Cadastro";
            this.data_Cadastro.Size = new System.Drawing.Size(144, 20);
            this.data_Cadastro.TabIndex = 68;
            this.data_Cadastro.Value = new System.DateTime(1899, 1, 1, 12, 0, 0, 0);
            // 
            // Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 386);
            this.Controls.Add(this.data_Cadastro);
            this.Controls.Add(this.data_Atualizacao);
            this.Controls.Add(this.ultima_Venda);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.removerButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.valor_venda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valor_custo);
            this.Controls.Add(this.codigo_barras);
            this.Controls.Add(this.nome);
            this.Name = "Produto";
            this.Text = "Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button removerButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox valor_venda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valor_custo;
        private System.Windows.Forms.TextBox codigo_barras;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.RichTextBox descricao;
        private System.Windows.Forms.DateTimePicker ultima_Venda;
        private System.Windows.Forms.DateTimePicker data_Atualizacao;
        private System.Windows.Forms.DateTimePicker data_Cadastro;
    }
}