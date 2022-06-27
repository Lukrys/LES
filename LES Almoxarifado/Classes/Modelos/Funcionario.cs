using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LES_Almoxarifado.Classes.Modelos
{
    class Funcionario
    {
        private ulong Codigo { get; set; }
        private string Nome { get; set; }
        private string Sobrenome { get; set; }
        private DateTime DataNascimento { get; set; }
        private string Cargo { get; set; }
        private Funcionario Gerente { get; set; }
        private bool Ativo { get; set; }

        public Funcionario() { }

        public Funcionario(string nome, string sobrenome, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.DataNascimento = dataNascimento;
        }

        public Funcionario(ulong codigo, Funcionario gerente, string cargo, bool ativo)
        {
            this.Codigo = codigo;
            this.Gerente = gerente;
            this.Cargo = cargo;
            this.Ativo = ativo;
        }

        public Funcionario(ulong codigo, string nome, string sobrenome, Funcionario gerente, string cargo, bool ativo)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Gerente = gerente;
            this.Cargo = cargo;
            this.Ativo = ativo;
        }
    }
}
