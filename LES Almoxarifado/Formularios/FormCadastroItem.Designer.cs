namespace LES_Almoxarifado.Formularios
{
    partial class FormCadastroItem
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFormCadItemAloc = new System.Windows.Forms.Button();
            this.btnFormCadItemCateg = new System.Windows.Forms.Button();
            this.btnFormCadItemForn = new System.Windows.Forms.Button();
            this.btnFormCadItemItem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFormCadItemAloc);
            this.panel2.Controls.Add(this.btnFormCadItemCateg);
            this.panel2.Controls.Add(this.btnFormCadItemForn);
            this.panel2.Controls.Add(this.btnFormCadItemItem);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 66);
            this.panel2.TabIndex = 2;
            // 
            // btnFormCadItemAloc
            // 
            this.btnFormCadItemAloc.Location = new System.Drawing.Point(565, 24);
            this.btnFormCadItemAloc.Margin = new System.Windows.Forms.Padding(10);
            this.btnFormCadItemAloc.Name = "btnFormCadItemAloc";
            this.btnFormCadItemAloc.Size = new System.Drawing.Size(145, 23);
            this.btnFormCadItemAloc.TabIndex = 3;
            this.btnFormCadItemAloc.Text = "Alocações";
            this.btnFormCadItemAloc.UseVisualStyleBackColor = true;
            this.btnFormCadItemAloc.Click += new System.EventHandler(this.BtnFormCadItemCateg_Click);
            // 
            // btnFormCadItemCateg
            // 
            this.btnFormCadItemCateg.Location = new System.Drawing.Point(400, 24);
            this.btnFormCadItemCateg.Margin = new System.Windows.Forms.Padding(10);
            this.btnFormCadItemCateg.Name = "btnFormCadItemCateg";
            this.btnFormCadItemCateg.Size = new System.Drawing.Size(145, 23);
            this.btnFormCadItemCateg.TabIndex = 2;
            this.btnFormCadItemCateg.Text = "Categorias";
            this.btnFormCadItemCateg.UseVisualStyleBackColor = true;
            this.btnFormCadItemCateg.Click += new System.EventHandler(this.BtnFormCadItemForn_Click);
            // 
            // btnFormCadItemForn
            // 
            this.btnFormCadItemForn.Location = new System.Drawing.Point(235, 24);
            this.btnFormCadItemForn.Margin = new System.Windows.Forms.Padding(10);
            this.btnFormCadItemForn.Name = "btnFormCadItemForn";
            this.btnFormCadItemForn.Size = new System.Drawing.Size(145, 23);
            this.btnFormCadItemForn.TabIndex = 1;
            this.btnFormCadItemForn.Text = "Fornecedores";
            this.btnFormCadItemForn.UseVisualStyleBackColor = true;
            this.btnFormCadItemForn.Click += new System.EventHandler(this.BtnFormCadItemForn_Click);
            // 
            // btnFormCadItemItem
            // 
            this.btnFormCadItemItem.Location = new System.Drawing.Point(70, 24);
            this.btnFormCadItemItem.Margin = new System.Windows.Forms.Padding(10);
            this.btnFormCadItemItem.Name = "btnFormCadItemItem";
            this.btnFormCadItemItem.Size = new System.Drawing.Size(145, 23);
            this.btnFormCadItemItem.TabIndex = 0;
            this.btnFormCadItemItem.Text = "Itens";
            this.btnFormCadItemItem.UseVisualStyleBackColor = true;
            this.btnFormCadItemItem.Click += new System.EventHandler(this.FormCadItemItem_Click);
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Location = new System.Drawing.Point(12, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 354);
            this.panel3.TabIndex = 3;
            // 
            // FormCadastroItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "FormCadastroItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUsuarios";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFormCadItemAloc;
        private System.Windows.Forms.Button btnFormCadItemCateg;
        private System.Windows.Forms.Button btnFormCadItemForn;
        private System.Windows.Forms.Button btnFormCadItemItem;
        private System.Windows.Forms.Panel panel3;
    }
}