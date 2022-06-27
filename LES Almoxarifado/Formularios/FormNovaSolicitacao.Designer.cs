namespace LES_Almoxarifado.Formularios
{
    partial class FormNovaSolicitacao
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
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblQtde = new System.Windows.Forms.Label();
            this.cbxMaterial = new System.Windows.Forms.ComboBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.lblCustoTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnAdicionar.Location = new System.Drawing.Point(176, 216);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(87, 29);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.IndianRed;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFechar.Location = new System.Drawing.Point(306, 216);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(87, 29);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "Cancelar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(23, 78);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(44, 13);
            this.lblMaterial.TabIndex = 2;
            this.lblMaterial.Text = "Material";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(269, 78);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lblFornecedor.TabIndex = 3;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Location = new System.Drawing.Point(23, 130);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(62, 13);
            this.lblQtde.TabIndex = 4;
            this.lblQtde.Text = "Quantidade";
            // 
            // cbxMaterial
            // 
            this.cbxMaterial.FormattingEnabled = true;
            this.cbxMaterial.Items.AddRange(new object[] {
            "Pneu 175mm",
            "Pneu 185mm",
            "Pneu 225mm",
            "Monitor 20\"",
            "Monitor 45\"",
            "Mouse",
            "Teclado",
            "Computador",
            "Kit embreagem",
            "Lâmpada de farol",
            "Óleo do motor",
            "Filtro de óleo",
            "Filtro de combústivel"});
            this.cbxMaterial.Location = new System.Drawing.Point(73, 75);
            this.cbxMaterial.Name = "cbxMaterial";
            this.cbxMaterial.Size = new System.Drawing.Size(190, 21);
            this.cbxMaterial.TabIndex = 5;
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(91, 127);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(100, 20);
            this.txtQtde.TabIndex = 7;
            this.txtQtde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQtde_KeyDown);
            // 
            // lblCustoTotal
            // 
            this.lblCustoTotal.AutoSize = true;
            this.lblCustoTotal.Location = new System.Drawing.Point(23, 174);
            this.lblCustoTotal.Name = "lblCustoTotal";
            this.lblCustoTotal.Size = new System.Drawing.Size(31, 13);
            this.lblCustoTotal.TabIndex = 8;
            this.lblCustoTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(60, 171);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 10;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(23, 29);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(40, 13);
            this.lblCod.TabIndex = 11;
            this.lblCod.Text = "Código";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(69, 26);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(57, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "012";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "João Peças",
            "Fate-Tech",
            "Flavin do Pneu",
            "Sorocaba motors"});
            this.comboBox1.Location = new System.Drawing.Point(336, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // FormNovaSolicitacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 260);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblCustoTotal);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.cbxMaterial);
            this.Controls.Add(this.lblQtde);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "FormNovaSolicitacao";
            this.Text = "Abrir nova solicitação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.ComboBox cbxMaterial;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label lblCustoTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}