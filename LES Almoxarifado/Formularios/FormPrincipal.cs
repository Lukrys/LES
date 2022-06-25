using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LES_Almoxarifado.Classes;
using System.Windows.Forms;
using LES_Almoxarifado.Formularios;

namespace LES_Almoxarifado
{
    public partial class FormPrincipal : Form
    {
        

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSobre formSobre = new FormSobre();
            formSobre.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
