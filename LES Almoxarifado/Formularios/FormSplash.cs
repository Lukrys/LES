using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using LES_Almoxarifado.Classes;

namespace LES_Almoxarifado
{
    public partial class FormSplash : Form
    {
        List<Object> MyObjList = new List<Object>();
        public FormSplash(String s = null)
        {
            InitializeComponent();
        }

        /*public Boolean ConectaDB()
        {
            try
            {
                ConexaoBD.ConectarBanco();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }*/
    }
}
