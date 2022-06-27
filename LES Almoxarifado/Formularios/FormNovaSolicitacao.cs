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
    public partial class FormNovaSolicitacao : Form
    {
        public FormNovaSolicitacao()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtQtde_KeyDown(object sender, KeyEventArgs e)
        {
            txtTotal.Text = "R$ 2068,80";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
