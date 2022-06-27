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
    public partial class FormInventario : Form
    {

        static FormIncluirItem formIncluirItem = new FormIncluirItem();

        public FormInventario()
        {
            InitializeComponent();

            string[] row1 = { "Pneu 175mm", "24", "A1-2" };
            listView1.Items.Add("0092").SubItems.AddRange(row1);
            string[] row2 = { "Pneu 185mm", "4", "A1-1" };
            listView1.Items.Add("0093").SubItems.AddRange(row2);
            string[] row3 = { "Monitor 20''", "2", "A2-17" };
            listView1.Items.Add("0222").SubItems.AddRange(row3);
            string[] row4 = { "Filtro de óleo", "19", "B2-8" };
            listView1.Items.Add("1101").SubItems.AddRange(row4);
            string[] row5 = { "Kit embreagem", "3", "A1-3" };
            listView1.Items.Add("757").SubItems.AddRange(row5);
            string[] row6 = { "Teclado", "25", "A2-10" };
            listView1.Items.Add("0252").SubItems.AddRange(row6);
            string[] row7 = { "Kit embreagem", "6", "A1-3" };
            listView1.Items.Add("757").SubItems.AddRange(row7);
            string[] row8 = { "Pneu 225mm", "8", "A1-4" };
            listView1.Items.Add("0094").SubItems.AddRange(row8);
            string[] row9 = { "Óleo do motor", "32", "B1-3" };
            listView1.Items.Add("390").SubItems.AddRange(row9);
            string[] row10 = { "Lâmpada do farol", "13", "A1-11" };
            listView1.Items.Add("0174").SubItems.AddRange(row10);
            string[] row11 = { "Lâmpada do farol", "49", "A1-8" };
            listView1.Items.Add("0174").SubItems.AddRange(row11);
            string[] row12 = { "Monitor 45''", "7", "A2-14" };
            listView1.Items.Add("0221").SubItems.AddRange(row12);
            string[] row13 = { "Pneu 185mm", "8", "A1-7" };
            listView1.Items.Add("0093").SubItems.AddRange(row13);
            string[] row14 = { "Kit embreagem", "3", "A2-2" };
            listView1.Items.Add("757").SubItems.AddRange(row14);
            string[] row15 = { "Pneu 185mm", "4", "A1-11" };
            listView1.Items.Add("0093").SubItems.AddRange(row15);
            string[] row16 = { "Filtro de combustível", "26", "B2-5" };
            listView1.Items.Add("1046").SubItems.AddRange(row16);
            string[] row17 = { "Pneu 185mm", "16", "A1-3" };
            listView1.Items.Add("0093").SubItems.AddRange(row17);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            formIncluirItem.Show();
        }
    }
}
