using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using LES_Almoxarifado.Formularios;
using LES_Almoxarifado.Classes;
using System.Configuration;
using System.Diagnostics;

namespace LES_Almoxarifado
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>

        static FormSplash formSplash;
        static FormLogin formLogin;
        static Boolean dbConectado;
        public static bool usuarioAutorizado = false;
        static Dictionary<string, bool> dadosUser = new Dictionary<string, bool>();


        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           

            formSplash = new FormSplash();
            formSplash.ShowInTaskbar = false;
            formSplash.Show();
            
            //dbConectado = formSplash.ConectaDB();

            /*if(dbConectado)
            {*/
                formSplash.Hide();

                formLogin = new FormLogin();
                Application.Run(formLogin);
            /*}

             Application.Run(new FormSplash());

            return;*/
        }
    }
}
