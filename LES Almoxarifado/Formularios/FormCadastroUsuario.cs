using System;
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
            txtCargo.Clear();
            txtEmail.Clear();
            txtLogin.Clear();
            txtNome.Clear();
            txtSobrenome.Clear();
            mskdTxtDatNasc.Clear();
            MessageBox.Show("Usuário cadastrado com sucesso.", "Usuário cadastrado", MessageBoxButtons.OK);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
