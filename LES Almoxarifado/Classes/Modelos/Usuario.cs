using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LES_Almoxarifado.Classes.Modelos
{
    class Usuario
    {
        private ulong Codigo { get; set; }
        private Funcionario Funcionario { get; set; }
        private Permissoes Permissoes { get; set; }
        private String NomeUsuario { get; set; }
        private String SenhaUsuario { get; set; }
        private String EmailRecuperacao { get; set; }

        public Usuario() { }

        public Usuario(Funcionario funcionario, Permissoes permissoes, string nomeUsuario, string senhaUsuario,string emailRecuperacao)
        {
            this.Funcionario = funcionario;
            this.Permissoes = permissoes;
            this.NomeUsuario = nomeUsuario;
            this.SenhaUsuario = senhaUsuario;
            this.EmailRecuperacao = emailRecuperacao;
        }

        public Usuario(ulong codigo, Funcionario funcionario, Permissoes permissoes, string nomeUsuario, string senhaUsuario, string emailRecuperacao)
        {
            this.Codigo = codigo;
            this.Funcionario = funcionario;
            this.Permissoes = permissoes;
            this.NomeUsuario = nomeUsuario;
            this.SenhaUsuario = senhaUsuario;
            this.EmailRecuperacao = emailRecuperacao;
        }
    }
}
