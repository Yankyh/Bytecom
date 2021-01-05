
namespace Bytecom.Pedido
{
    partial class Pedido
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
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.valor_produto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.data_emissao = new System.Windows.Forms.DateTimePicker();
            this.valor_desconto = new System.Windows.Forms.TextBox();
            this.valor_total = new System.Windows.Forms.TextBox();
            this.id_cliente = new System.Windows.Forms.ComboBox();
            this.data_Atualizacao = new System.Windows.Forms.DateTimePicker();
            this.data_Cadastro = new System.Windows.Forms.DateTimePicker();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // removerButton
            // 
            this.removerButton.Location = new System.Drawing.Point(633, 328);
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
            this.button1.Location = new System.Drawing.Point(714, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 54;
            this.button1.Text = "Gravar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GravarOnClick);
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(688, 35);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Size = new System.Drawing.Size(101, 20);
            this.id.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(685, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Código";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Data de cadastro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Valor total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Valor desconto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Valor produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Cliente";
            // 
            // valor_produto
            // 
            this.valor_produto.Location = new System.Drawing.Point(289, 35);
            this.valor_produto.Name = "valor_produto";
            this.valor_produto.Size = new System.Drawing.Size(77, 20);
            this.valor_produto.TabIndex = 31;
            this.valor_produto.TextChanged += new System.EventHandler(this.ValorProdutoOnTextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(173, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Data de atualização";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Data de emissão";
            // 
            // data_emissao
            // 
            this.data_emissao.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.data_emissao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_emissao.Location = new System.Drawing.Point(538, 35);
            this.data_emissao.Name = "data_emissao";
            this.data_emissao.Size = new System.Drawing.Size(144, 20);
            this.data_emissao.TabIndex = 58;
            // 
            // valor_desconto
            // 
            this.valor_desconto.Location = new System.Drawing.Point(372, 35);
            this.valor_desconto.Name = "valor_desconto";
            this.valor_desconto.Size = new System.Drawing.Size(77, 20);
            this.valor_desconto.TabIndex = 59;
            this.valor_desconto.TextChanged += new System.EventHandler(this.ValorDescontoOnTextChanged);
            // 
            // valor_total
            // 
            this.valor_total.Location = new System.Drawing.Point(455, 35);
            this.valor_total.Name = "valor_total";
            this.valor_total.Size = new System.Drawing.Size(77, 20);
            this.valor_total.TabIndex = 60;
            this.valor_total.TextChanged += new System.EventHandler(this.ValorTotalOnTextChanged);
            // 
            // id_cliente
            // 
            this.id_cliente.FormattingEnabled = true;
            this.id_cliente.Location = new System.Drawing.Point(22, 35);
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.Size = new System.Drawing.Size(261, 21);
            this.id_cliente.TabIndex = 63;
            this.id_cliente.DropDown += new System.EventHandler(this.ClienteOnDropDown);
            // 
            // data_Atualizacao
            // 
            this.data_Atualizacao.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.data_Atualizacao.Enabled = false;
            this.data_Atualizacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_Atualizacao.Location = new System.Drawing.Point(176, 334);
            this.data_Atualizacao.Name = "data_Atualizacao";
            this.data_Atualizacao.Size = new System.Drawing.Size(144, 20);
            this.data_Atualizacao.TabIndex = 64;
            this.data_Atualizacao.Value = new System.DateTime(1899, 1, 1, 12, 0, 0, 0);
            // 
            // data_Cadastro
            // 
            this.data_Cadastro.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.data_Cadastro.Enabled = false;
            this.data_Cadastro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.data_Cadastro.Location = new System.Drawing.Point(26, 334);
            this.data_Cadastro.Name = "data_Cadastro";
            this.data_Cadastro.Size = new System.Drawing.Size(144, 20);
            this.data_Cadastro.TabIndex = 65;
            this.data_Cadastro.Value = new System.DateTime(1899, 1, 1, 12, 0, 0, 0);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.itemDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(759, 206);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Produto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(720, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 23);
            this.button3.TabIndex = 68;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ExcluirItemButtonOnClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(681, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 23);
            this.button2.TabIndex = 67;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AdicionarItemButtonOnClick);
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.AllowUserToAddRows = false;
            this.itemDataGridView.AllowUserToDeleteRows = false;
            this.itemDataGridView.AllowUserToResizeRows = false;
            this.itemDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView.Location = new System.Drawing.Point(6, 43);
            this.itemDataGridView.MultiSelect = false;
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.ReadOnly = true;
            this.itemDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.itemDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemDataGridView.Size = new System.Drawing.Size(747, 160);
            this.itemDataGridView.TabIndex = 66;
            this.itemDataGridView.DoubleClick += new System.EventHandler(this.ProdutoGridOnDoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(22, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(767, 232);
            this.tabControl1.TabIndex = 67;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 372);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.data_Cadastro);
            this.Controls.Add(this.data_Atualizacao);
            this.Controls.Add(this.id_cliente);
            this.Controls.Add(this.valor_total);
            this.Controls.Add(this.valor_desconto);
            this.Controls.Add(this.data_emissao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.removerButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valor_produto);
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.Activated += new System.EventHandler(this.OnFocusActivated);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button removerButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valor_produto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker data_emissao;
        private System.Windows.Forms.TextBox valor_desconto;
        private System.Windows.Forms.TextBox valor_total;
        private System.Windows.Forms.ComboBox id_cliente;
        private System.Windows.Forms.DateTimePicker data_Atualizacao;
        private System.Windows.Forms.DateTimePicker data_Cadastro;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView itemDataGridView;
        private System.Windows.Forms.TabControl tabControl1;
    }
}