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
    public partial class FormCadastroItem : Form
    {
        public FormCadastroItem()
        {
            InitializeComponent();
        }

        public void PopMessageBox(Exception ex)
        {
            MessageBox.Show("Não foi possível abrir a tela. Erro: " + ex.Message, "Erro");
        }

        private void FormCadItemItem_Click(object sender, EventArgs e)
        {
            FormCadastroItemIndividual formCadastroItemIndividual = new FormCadastroItemIndividual();
            try
            {
                formCadastroItemIndividual.Show();
            } catch(Exception ex)
            {
                PopMessageBox(ex);
            }
        }

        private void BtnFormCadItemForn_Click(object sender, EventArgs e)
        {
            FormCadastroFornecedores formCadastroFornecedores = new FormCadastroFornecedores();
            try
            {
                formCadastroFornecedores.Show();
            } catch(Exception ex)
            {
                PopMessageBox(ex);
            }
        }

        private void BtnFormCadItemCateg_Click(object sender, EventArgs e)
        {
            FormCadastroFornecedores formCadastroFornecedores = new FormCadastroFornecedores();
            try
            {
                formCadastroFornecedores.Show();
            }
            catch (Exception ex)
            {
                PopMessageBox(ex);
            }
        }

        private void BtnFormCadItemAloc_Click(object sender, EventArgs e)
        {
            FormCadastroAlocacoes formCadastroAlocacoes = new FormCadastroAlocacoes();
            try
            {
                formCadastroAlocacoes.Show();
            } catch(Exception ex)
            {
                PopMessageBox(ex);
            }
        }


    }
}
