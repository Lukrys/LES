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
    public partial class FormCadastroFornecedores : Form
    {
        public class Fornecedor
        {
            public ulong Codigo { get; set; }
            public string Descricao { get; set; }
        }

        public FormCadastroFornecedores()
        {
            InitializeComponent();

            var fornecedores = new List<Fornecedor>();
            fornecedores.Add(new Fornecedor() { Codigo = 1, Descricao = "João Peças" });
            fornecedores.Add(new Fornecedor() { Codigo = 2, Descricao = "Fate-Tech" });
            fornecedores.Add(new Fornecedor() { Codigo = 3, Descricao = "Flavin do Pneu" });
            fornecedores.Add(new Fornecedor() { Codigo = 4, Descricao = "Sorocaba Motors" });

            this.cbxFornecedor.DataSource = fornecedores;
            this.cbxFornecedor.DisplayMember = "Descricao";
            this.cbxFornecedor.ValueMember = "Codigo";

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            txtFornecedor.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
        }
    }
}
