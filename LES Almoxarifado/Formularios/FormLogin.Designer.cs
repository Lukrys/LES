namespace LES_Almoxarifado.Formularios
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.txtFormLoginUser = new System.Windows.Forms.TextBox();
            this.txtFormLoginPass = new System.Windows.Forms.MaskedTextBox();
            this.lblLoginUsuario = new System.Windows.Forms.Label();
            this.lblLoginSenha = new System.Windows.Forms.Label();
            this.btnLoginSair = new System.Windows.Forms.Button();
            this.btnLoginRecuperar = new System.Windows.Forms.Button();
            this.btnLoginEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFormLoginUser
            // 
            this.txtFormLoginUser.Location = new System.Drawing.Point(205, 42);
            this.txtFormLoginUser.Name = "txtFormLoginUser";
            this.txtFormLoginUser.Size = new System.Drawing.Size(122, 20);
            this.txtFormLoginUser.TabIndex = 0;
            // 
            // txtFormLoginPass
            // 
            this.txtFormLoginPass.Location = new System.Drawing.Point(205, 82);
            this.txtFormLoginPass.Name = "txtFormLoginPass";
            this.txtFormLoginPass.Size = new System.Drawing.Size(122, 20);
            this.txtFormLoginPass.TabIndex = 1;
            // 
            // lblLoginUsuario
            // 
            this.lblLoginUsuario.Location = new System.Drawing.Point(77, 42);
            this.lblLoginUsuario.Name = "lblLoginUsuario";
            this.lblLoginUsuario.Size = new System.Drawing.Size(122, 20);
            this.lblLoginUsuario.TabIndex = 2;
            this.lblLoginUsuario.Text = "Usuário";
            this.lblLoginUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLoginSenha
            // 
            this.lblLoginSenha.Location = new System.Drawing.Point(77, 81);
            this.lblLoginSenha.Name = "lblLoginSenha";
            this.lblLoginSenha.Size = new System.Drawing.Size(122, 20);
            this.lblLoginSenha.TabIndex = 3;
            this.lblLoginSenha.Text = "Senha";
            this.lblLoginSenha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLoginSair
            // 
            this.btnLoginSair.Location = new System.Drawing.Point(9, 144);
            this.btnLoginSair.Name = "btnLoginSair";
            this.btnLoginSair.Size = new System.Drawing.Size(108, 23);
            this.btnLoginSair.TabIndex = 4;
            this.btnLoginSair.Text = "Sair";
            this.btnLoginSair.UseVisualStyleBackColor = true;
            this.btnLoginSair.Click += new System.EventHandler(this.btnLoginSair_Click);
            // 
            // btnLoginRecuperar
            // 
            this.btnLoginRecuperar.Location = new System.Drawing.Point(280, 144);
            this.btnLoginRecuperar.Name = "btnLoginRecuperar";
            this.btnLoginRecuperar.Size = new System.Drawing.Size(108, 23);
            this.btnLoginRecuperar.TabIndex = 5;
            this.btnLoginRecuperar.Text = "Recuperar Senha";
            this.btnLoginRecuperar.UseVisualStyleBackColor = true;
            // 
            // btnLoginEntrar
            // 
            this.btnLoginEntrar.Location = new System.Drawing.Point(148, 144);
            this.btnLoginEntrar.Name = "btnLoginEntrar";
            this.btnLoginEntrar.Size = new System.Drawing.Size(108, 23);
            this.btnLoginEntrar.TabIndex = 6;
            this.btnLoginEntrar.Text = "Entrar";
            this.btnLoginEntrar.UseVisualStyleBackColor = true;
            this.btnLoginEntrar.Click += new System.EventHandler(this.BtnLoginEntrar_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.btnLoginEntrar);
            this.Controls.Add(this.btnLoginRecuperar);
            this.Controls.Add(this.btnLoginSair);
            this.Controls.Add(this.lblLoginSenha);
            this.Controls.Add(this.lblLoginUsuario);
            this.Controls.Add(this.txtFormLoginPass);
            this.Controls.Add(this.txtFormLoginUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 200);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFormLoginUser;
        private System.Windows.Forms.MaskedTextBox txtFormLoginPass;
        private System.Windows.Forms.Label lblLoginUsuario;
        private System.Windows.Forms.Label lblLoginSenha;
        private System.Windows.Forms.Button btnLoginSair;
        private System.Windows.Forms.Button btnLoginRecuperar;
        private System.Windows.Forms.Button btnLoginEntrar;
    }
}