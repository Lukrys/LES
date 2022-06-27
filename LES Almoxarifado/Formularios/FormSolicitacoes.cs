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
    public partial class FormSolicitacoes : Form
    {
        static FormNovaSolicitacao formNovaSolicitacao = new FormNovaSolicitacao();

        public FormSolicitacoes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            formNovaSolicitacao.Show();
        }
    }
}
