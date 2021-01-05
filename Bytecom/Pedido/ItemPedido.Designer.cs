
namespace Bytecom.Pedido
{
    partial class ItemPedido
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
            this.id_produto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.id_Pedido_Venda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.valor_Custo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.quantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.valor_Total = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.valor_Venda = new System.Windows.Forms.TextBox();
            this.data_Cadastro = new System.Windows.Forms.DateTimePicker();
            this.data_Atualizacao = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.removerButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id_produto
            // 
            this.id_produto.FormattingEnabled = true;
            this.id_produto.Location = new System.Drawing.Point(12, 46);
            this.id_produto.Name = "id_produto";
            this.id_produto.Size = new System.Drawing.Size(261, 21);
            this.id_produto.TabIndex = 65;
            this.id_produto.DropDown += new System.EventHandler(this.ProdutoOnDropDown);
            this.id_produto.SelectedIndexChanged += new System.EventHandler(this.ProdutoOnSelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Produto";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(527, 46);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(101, 20);
            this.id.TabIndex = 67;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(524, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 66;
            this.label11.Text = "Código";
            // 
            // id_Pedido_Venda
            // 
            this.id_Pedido_Venda.Location = new System.Drawing.Point(119, 96);
            this.id_Pedido_Venda.Name = "id_Pedido_Venda";
            this.id_Pedido_Venda.ReadOnly = true;
            this.id_Pedido_Venda.Size = new System.Drawing.Size(101, 20);
            this.id_Pedido_Venda.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Pedido";
            // 
            // valor_Custo
            // 
            this.valor_Custo.Location = new System.Drawing.Point(12, 96);
            this.valor_Custo.Name = "valor_Custo";
            this.valor_Custo.ReadOnly = true;
            this.valor_Custo.Size = new System.Drawing.Size(101, 20);
            this.valor_Custo.TabIndex = 71;
            this.valor_Custo.TextChanged += new System.EventHandler(this.ValorCustoOnTextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Valor custo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Quantidade";
            // 
            // quantidade
            // 
            this.quantidade.Location = new System.Drawing.Point(279, 47);
            this.quantidade.Name = "quantidade";
            this.quantidade.Size = new System.Drawing.Size(77, 20);
            this.quantidade.TabIndex = 72;
            this.quantidade.TextChanged += new System.EventHandler(this.QuantidadeOnTextChanged);
            this.quantidade.Leave += new System.EventHandler(this.QuantidadeOnLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Valor total";
            // 
            // valor_Total
            // 
            this.valor_Total.Location = new System.Drawing.Point(444, 47);
            this.valor_Total.Name = "valor_Total";
            this.valor_Total.ReadOnly = true;
            this.valor_Total.Size = new System.Drawing.Size(77, 20);
            this.valor_Total.TabIndex = 74;
            this.valor_Total.TextChanged += new System.EventHandler(this.ValorTotalOnTextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 77;
            this.label6.Text = "Valor venda";
            // 
            // valor_Venda
            // 
            this.valor_Venda.Location = new System.Drawing.Point(361, 47);
            this.valor_Venda.Name = "valor_Venda";
            this.valor_Venda.Size = new System.Drawing.Size(77, 20);
            this.valor_Venda.TabIndex = 76;
            this.valor_Venda.TextChanged += new System.EventHandler(this.ValorVendaOnTextChanged);
            this.valor_Venda.Leave += new System.EventHandler(this.ValorVendaOnLeave);
            // 
            // data_Cadastro
            // 
            this.data_Cadastro.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.data_Cadastro.Enabled = false;
            this.data_Cadastro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_Cadastro.Location = new System.Drawing.Point(12, 248);
            this.data_Cadastro.Name = "data_Cadastro";
            this.data_Cadastro.Size = new System.Drawing.Size(144, 20);
            this.data_Cadastro.TabIndex = 81;
            this.data_Cadastro.Value = new System.DateTime(1899, 1, 1, 12, 0, 0, 0);
            // 
            // data_Atualizacao
            // 
            this.data_Atualizacao.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.data_Atualizacao.Enabled = false;
            this.data_Atualizacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_Atualizacao.Location = new System.Drawing.Point(162, 248);
            this.data_Atualizacao.Name = "data_Atualizacao";
            this.data_Atualizacao.Size = new System.Drawing.Size(144, 20);
            this.data_Atualizacao.TabIndex = 80;
            this.data_Atualizacao.Value = new System.DateTime(1899, 1, 1, 12, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(159, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 79;
            this.label9.Text = "Data de atualização";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 78;
            this.label8.Text = "Data de cadastro";
            // 
            // removerButton
            // 
            this.removerButton.Location = new System.Drawing.Point(470, 248);
            this.removerButton.Name = "removerButton";
            this.removerButton.Size = new System.Drawing.Size(75, 23);
            this.removerButton.TabIndex = 83;
            this.removerButton.Text = "Excluir";
            this.removerButton.UseVisualStyleBackColor = true;
            this.removerButton.Visible = false;
            this.removerButton.Click += new System.EventHandler(this.RemoverButtonOnClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 82;
            this.button1.Text = "Gravar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GravarOnClick);
            // 
            // ItemPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 280);
            this.Controls.Add(this.removerButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.data_Cadastro);
            this.Controls.Add(this.data_Atualizacao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.valor_Venda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.valor_Total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.quantidade);
            this.Controls.Add(this.valor_Custo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.id_Pedido_Venda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.id_produto);
            this.Controls.Add(this.label1);
            this.Name = "ItemPedido";
            this.Text = "Item do pedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox id_produto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox id_Pedido_Venda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valor_Custo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox quantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox valor_Total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox valor_Venda;
        private System.Windows.Forms.DateTimePicker data_Cadastro;
        private System.Windows.Forms.DateTimePicker data_Atualizacao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button removerButton;
        private System.Windows.Forms.Button button1;
    }
}