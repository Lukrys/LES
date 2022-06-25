using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using System.Data;

/*namespace LES_Almoxarifado.Classes
{
    class ConexaoBD
    {
        // cria a string de conexão baseada em configuração xml
        public static string oradb = ConfigurationManager.AppSettings["oraStrConex"].ToString();

        public static DataTable dt = new DataTable();
        public static Dictionary<string, bool> dict = new Dictionary<string, bool>();

        // armazena o estado da conexão
        private static Boolean BancoConectado { get; set; } = false;

        // instância da conexão
        private static OracleConnection conn = new OracleConnection(oradb);

        public static Boolean EstadoConexao()
        {
            return BancoConectado;
        }

        public static Boolean ConectarBanco()
        {
            try
            {
                conn.Open();
                BancoConectado = ! BancoConectado;

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return false;

        }

        public static Boolean DesconectarBanco()
        {
            try
            {
                conn.Close();
                BancoConectado = !BancoConectado;
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }

        private static Boolean ChecaListaObjetos(List<Object> list)
        {
            if(list.Count() > 0)
            {
                return true;
            }
            return false;
        }

        public static Boolean insert(List<Object> list)
        {
            if (ChecaListaObjetos(list))
            {
                // prepara lista de registros para inserção
                try
                {
                    // executa inserção

                }
                catch (Exception)
                {
                    // invoca classe utilitaria para exibir modal com mensagem user-friendly,
                    // e insere erro no log (do SO, e não do BD)

                    throw;
                }
                finally
                {
                    // libera recursos ou realiza ações adicionais
                }
            }
            return false;
        }

        public static Boolean update(List<Object> list)
        {
            if (ChecaListaObjetos(list))
            {
                // prepara lista de registros para inserção
                try
                {
                    // executa inserção
                }
                catch (Exception)
                {
                    // invoca classe utilitaria para exibir modal com mensagem user-friendly,
                    // e insere erro no log (do SO, e não do BD)

                    throw;
                }
                finally
                {
                    // libera recursos ou realiza ações adicionais
                }
            }
            return false;
        }

        public static Boolean delete(List<Object> list)
        {
            if (ChecaListaObjetos(list))
            {
                // prepara lista de registros para inserção
                try
                {
                    // executa inserção
                }
                catch (Exception)
                {
                    // invoca classe utilitaria para exibir modal com mensagem user-friendly,
                    // e insere erro no log (do SO, e não do BD)

                    throw;
                }
                finally
                {
                    // libera recursos ou realiza ações adicionais
                }
            }
            return false;
        }

        public static List<Object> getList()
        {
            return new List<object>();
        }

        static string sql;

        public static bool Login(string username, string password)
        {
            sql = "SELECT CODIGO, CODIGOFUNCIONARIO, NOMEUSUARIO, SENHAUSUARIO, CODIGOPERMISSOES, " +
                "EMAILRECUPERACAO FROM USUARIOS WHERE NOMEUSUARIO = '" + username + "' AND SENHAUSUARIO = '" + password + "'";

            OracleCommand cmd = new OracleCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            OracleDataReader reader = cmd.ExecuteReader();
            
            dt.Load(reader);

            if(dt != null && dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
*/