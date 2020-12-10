
namespace Bytecom
{
    partial class Bytecom
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
            this.pedidoButton = new System.Windows.Forms.Button();
            this.pessoaButton = new System.Windows.Forms.Button();
            this.produtoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pedidoButton
            // 
            this.pedidoButton.Location = new System.Drawing.Point(173, 12);
            this.pedidoButton.Name = "pedidoButton";
            this.pedidoButton.Size = new System.Drawing.Size(75, 23);
            this.pedidoButton.TabIndex = 0;
            this.pedidoButton.Text = "Pedido";
            this.pedidoButton.UseVisualStyleBackColor = true;
            this.pedidoButton.Click += new System.EventHandler(this.pedidoButtonOnClick);
            // 
            // pessoaButton
            // 
            this.pessoaButton.Location = new System.Drawing.Point(11, 12);
            this.pessoaButton.Name = "pessoaButton";
            this.pessoaButton.Size = new System.Drawing.Size(75, 23);
            this.pessoaButton.TabIndex = 1;
            this.pessoaButton.Text = "Pessoa";
            this.pessoaButton.UseVisualStyleBackColor = true;
            this.pessoaButton.Click += new System.EventHandler(this.pessoaButtonOnClick);
            // 
            // produtoButton
            // 
            this.produtoButton.Location = new System.Drawing.Point(92, 12);
            this.produtoButton.Name = "produtoButton";
            this.produtoButton.Size = new System.Drawing.Size(75, 23);
            this.produtoButton.TabIndex = 2;
            this.produtoButton.Text = "Produto";
            this.produtoButton.UseVisualStyleBackColor = true;
            this.produtoButton.Click += new System.EventHandler(this.produtoButtonOnClick);
            // 
            // Bytecom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 592);
            this.Controls.Add(this.produtoButton);
            this.Controls.Add(this.pessoaButton);
            this.Controls.Add(this.pedidoButton);
            this.Name = "Bytecom";
            this.Text = "Bytecom";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pedidoButton;
        private System.Windows.Forms.Button pessoaButton;
        private System.Windows.Forms.Button produtoButton;
    }
}

