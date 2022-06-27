using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LES_Almoxarifado.Classes;
using System.Data.SqlClient;

namespace LES_Almoxarifado.Formularios
{
    public partial class FormLogin : Form
    {
        public string strConn;
        private string defaultUser = "almoxarifado";
        private string defaultPassword = "teste123";

        static FormPrincipal formPrincipal = new FormPrincipal();
        static FormRecuperaSenha formRecuperaSenha = new FormRecuperaSenha();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLoginSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void BtnLoginEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(String.IsNullOrEmpty(txtFormLoginUser.Text) && String.IsNullOrEmpty(txtFormLoginPass.Text))
                {
                    MessageBox.Show("Usuário ou Senha não podem ser vazios", "Erro");
                }
                else
                {
                    if(txtFormLoginUser.Text == defaultUser && txtFormLoginPass.Text == defaultPassword)
                   {
                       Program.usuarioAutorizado = true;
                       this.Hide();
                       formPrincipal.Show();
                   }
                   /*else if(ConexaoBD.Login(txtFormLoginUser.Text, txtFormLoginPass.Text))
                   {
                       Program.usuarioAutorizado = true;
                       this.Hide();
                       formPrincipal.Show();
                   }*/
                    formPrincipal.Show();//usado apenas para teste sem o banco
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na Conexão. Detalhes: " + ex, "Erro");
            }
            
        }

        private void btnLoginRecuperar_Click(object sender, EventArgs e)
        {
            formRecuperaSenha.Show();
        }
    }
}
