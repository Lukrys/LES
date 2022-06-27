namespace LES_Almoxarifado.Formularios
{
    partial class FormCadastroFornecedores
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
            this.lblIncluirFornecedor = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblExcluirFornecedor = new System.Windows.Forms.Label();
            this.cbxFornecedor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblIncluirFornecedor
            // 
            this.lblIncluirFornecedor.AutoSize = true;
            this.lblIncluirFornecedor.Location = new System.Drawing.Point(36, 34);
            this.lblIncluirFornecedor.Name = "lblIncluirFornecedor";
            this.lblIncluirFornecedor.Size = new System.Drawing.Size(89, 13);
            this.lblIncluirFornecedor.TabIndex = 0;
            this.lblIncluirFornecedor.Text = "Incluir fornecedor";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(146, 31);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(252, 20);
            this.txtFornecedor.TabIndex = 1;
            // 
            // btnIncluir
            // 
            this.btnIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIncluir.Location = new System.Drawing.Point(404, 31);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 2;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.IndianRed;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFechar.Location = new System.Drawing.Point(214, 183);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(82, 31);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(404, 115);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblExcluirFornecedor
            // 
            this.lblExcluirFornecedor.AutoSize = true;
            this.lblExcluirFornecedor.Location = new System.Drawing.Point(36, 120);
            this.lblExcluirFornecedor.Name = "lblExcluirFornecedor";
            this.lblExcluirFornecedor.Size = new System.Drawing.Size(92, 13);
            this.lblExcluirFornecedor.TabIndex = 5;
            this.lblExcluirFornecedor.Text = "Excluir fornecedor";
            // 
            // cbxFornecedor
            // 
            this.cbxFornecedor.FormattingEnabled = true;
            this.cbxFornecedor.Location = new System.Drawing.Point(146, 115);
            this.cbxFornecedor.Name = "cbxFornecedor";
            this.cbxFornecedor.Size = new System.Drawing.Size(252, 21);
            this.cbxFornecedor.TabIndex = 6;
            // 
            // FormCadastroFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 235);
            this.Controls.Add(this.cbxFornecedor);
            this.Controls.Add(this.lblExcluirFornecedor);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.lblIncluirFornecedor);
            this.Name = "FormCadastroFornecedores";
            this.Text = "Cadastrar fornecedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIncluirFornecedor;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblExcluirFornecedor;
        private System.Windows.Forms.ComboBox cbxFornecedor;
    }
}