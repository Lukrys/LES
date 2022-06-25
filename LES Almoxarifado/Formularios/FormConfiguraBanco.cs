using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LES_Almoxarifado.Formularios
{
    public partial class FormConfiguraBanco : Form
    {
        private string oraExampleConnString = ConfigurationManager.AppSettings["oraExampleStrConex"].ToString();

        public FormConfiguraBanco()
        {
            InitializeComponent();

            txtConfiguraBDHost.Text = "127.0.0.1";
            txtConfiguraBDPorta.Text = "1521";
            cmbConfiguraBDTipo.SelectedValue = 0;
            txtConfiguraBDServico.Text = "XE";
            txtConfiguraBDUsuario.Text = "User";
            txtConfiguraBDSenha.Text = "Senha";
            lblConfiguraBancoConnString.Text = "String de Conexão: ";
        }

        private void BtnConfiguraBDTestar_Click(object sender, EventArgs e)
        {
            string strConexao = String.Format(
                oraExampleConnString,
                txtConfiguraBDHost.Text,
                txtConfiguraBDPorta.Text,
                cmbConfiguraBDTipo.SelectedItem,
                txtConfiguraBDServico.Text,
                txtConfiguraBDUsuario.Text,
                txtConfiguraBDSenha.Text
            );

            OracleConnection conn = new OracleConnection(strConexao);

            lblConfiguraBancoConnString.Text = strConexao;

            try
            {
                conn.Open();
                MessageBox.Show("Banco configurado com sucesso", "Sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    String.Format(
                        "Houve um erro ao conectar com o banco de dados: \n {0}", 
                        ex.Message
                    ), 
                    "Erro"
                );
            }
            finally
            {
                conn.Close();
            }

        }

        private void btnConfiguraBDSalvarSair_Click(object sender, EventArgs e)
        {
            String strConex = String.Format(
                oraExampleConnString,
                txtConfiguraBDHost.Text,
                txtConfiguraBDPorta.Text,
                cmbConfiguraBDTipo.Text,
                txtConfiguraBDServico.Text,
                txtConfiguraBDUsuario.Text,
                txtConfiguraBDSenha.Text
            );
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            // remove as configs existentes
            config.AppSettings.Settings.Remove("oraStrConex");
            config.AppSettings.Settings.Remove("oraHost");
            config.AppSettings.Settings.Remove("oraPort");
            config.AppSettings.Settings.Remove("oraServerType");
            config.AppSettings.Settings.Remove("oraServiceName");
            config.AppSettings.Settings.Remove("oraUser");
            config.AppSettings.Settings.Remove("oraPass");

            // insere as configs atualizadas
            config.AppSettings.Settings.Add("oraStrConex", strConex);
            config.AppSettings.Settings.Add("oraHost", txtConfiguraBDHost.Text);
            config.AppSettings.Settings.Add("oraPort", txtConfiguraBDPorta.Text);
            config.AppSettings.Settings.Add("oraServerType", cmbConfiguraBDTipo.Text);
            config.AppSettings.Settings.Add("oraServiceName", txtConfiguraBDServico.Text);
            config.AppSettings.Settings.Add("oraUser", txtConfiguraBDUsuario.Text);
            config.AppSettings.Settings.Add("oraPass", txtConfiguraBDSenha.Text);

            try
            {
                // salva no App.config
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                // alerta de sucesso
                MessageBox.Show("Configurações Salvas!", "Sucesso");
            }
            catch (ConfigurationException ex)
            {
                // alerta de erro
                MessageBox.Show("Erro ao salvar configurações: " + ex.Message, "Erro");
                throw ex;
            }

        }
    }
}
