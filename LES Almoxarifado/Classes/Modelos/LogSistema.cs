using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LES_Almoxarifado.Classes.Modelos
{
    class LogSistema
    {
        private ulong Codigo { get; set; }
        private DateTime DataHora { get; set; }
        private Usuario Usuario { get; set; }
        private string OperacaoExecutada { get; set; }
        private string Mensagem { get; set; }

        public LogSistema() { }

        public LogSistema(DateTime dataHora, Usuario usuario, string operacaoExecutada, string mensagem)
        {
            this.DataHora = dataHora;
            this.Usuario = usuario;
            this.OperacaoExecutada = operacaoExecutada;
            this.Mensagem = mensagem;
        }

        public LogSistema(ulong codigo, DateTime dataHora, Usuario usuario, string operacaoExecutada, string mensagem)
        {
            this.Codigo = codigo;
            this.DataHora = dataHora;
            this.Usuario = usuario;
            this.OperacaoExecutada = operacaoExecutada;
            this.Mensagem = mensagem;
        }

    }
}
