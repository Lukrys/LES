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
    public partial class FormCadastroUsuario : Form
    {
        public FormCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            String cargo, email, login, nome, sobrenome, dataNascimento;
            cargo = txtCargo.Text;
            email = txtEmail.Text;
            login = txtLogin.Text;
            nome = txtNome.Text;
            sobrenome = txtSobrenome.Text;
            dataNascimento = mskdTxtDatNasc.Text;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
