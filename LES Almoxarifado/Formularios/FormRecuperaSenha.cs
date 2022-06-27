﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LES_Almoxarifado.Formularios
{
    public partial class FormRecuperaSenha : Form
    {
        static FormCriarSenha formCriarSenha = new FormCriarSenha();
        static FormRecuperaSenha formRecuperaSenha = new FormRecuperaSenha();
        public FormRecuperaSenha()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Código incorreto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void CriarSenha_Click(object sender, EventArgs e)
        {
            formRecuperaSenha.Close();
            formCriarSenha.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Verifique a caixa de entrada do seu e-mail de recuperação.", "Nova senha enviada", MessageBoxButtons.OK);
        }
    }
}
