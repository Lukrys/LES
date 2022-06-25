namespace LES_Almoxarifado
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuItemPrincipalArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPrincipalCadFunc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPrincipalSolicitacoes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPrincipalSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemPrincipalArquivo,
            this.menuItemPrincipalCadFunc,
            this.menuItemPrincipalSolicitacoes,
            this.menuItemPrincipalSobre});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.menuPrincipal.TabIndex = 0;
            // 
            // menuItemPrincipalArquivo
            // 
            this.menuItemPrincipalArquivo.Name = "menuItemPrincipalArquivo";
            this.menuItemPrincipalArquivo.Size = new System.Drawing.Size(61, 20);
            this.menuItemPrincipalArquivo.Text = "Arquivo";
            // 
            // menuItemPrincipalCadFunc
            // 
            this.menuItemPrincipalCadFunc.Name = "menuItemPrincipalCadFunc";
            this.menuItemPrincipalCadFunc.Size = new System.Drawing.Size(66, 20);
            this.menuItemPrincipalCadFunc.Text = "Cadastro";
            // 
            // menuItemPrincipalSolicitacoes
            // 
            this.menuItemPrincipalSolicitacoes.Name = "menuItemPrincipalSolicitacoes";
            this.menuItemPrincipalSolicitacoes.Size = new System.Drawing.Size(81, 20);
            this.menuItemPrincipalSolicitacoes.Text = "Solicitações";
            // 
            // menuItemPrincipalSobre
            // 
            this.menuItemPrincipalSobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.menuItemPrincipalSobre.Name = "menuItemPrincipalSobre";
            this.menuItemPrincipalSobre.Size = new System.Drawing.Size(50, 20);
            this.menuItemPrincipalSobre.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.SobreToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuItemPrincipalArquivo;
        private System.Windows.Forms.ToolStripMenuItem menuItemPrincipalCadFunc;
        private System.Windows.Forms.ToolStripMenuItem menuItemPrincipalSolicitacoes;
        private System.Windows.Forms.ToolStripMenuItem menuItemPrincipalSobre;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}

