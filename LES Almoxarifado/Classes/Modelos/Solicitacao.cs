using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LES_Almoxarifado.Classes.Modelos
{
    class Solicitacao
    {
        private ulong Codigo { get; set; }
        private DateTime DataCriacao { get; set; }
        private Funcionario Requisitante { get; set; }
        private Funcionario OperadorAlmox { get; set; }
        private bool TipoPedido { get; set; }
        
        public Solicitacao() { }

        
        public Solicitacao(Funcionario requisitante, Funcionario operador, bool tipoPedido)
        {
            this.Requisitante = requisitante;
            this.OperadorAlmox = operador;
            this.TipoPedido = tipoPedido;
        }

        public Solicitacao(DateTime dataCriacao, Funcionario requisitante, Funcionario operador, bool tipoPedido)
        {
            this.DataCriacao = dataCriacao;
            this.Requisitante = requisitante;
            this.OperadorAlmox = operador;
            this.TipoPedido = tipoPedido;
        }

        public Solicitacao(ulong codigo, DateTime dataCriacao, Funcionario requisitante, Funcionario operador, bool tipoPedido)
        {
            this.Codigo = codigo;
            this.DataCriacao = dataCriacao;
            this.Requisitante = requisitante;
            this.OperadorAlmox = operador;
            this.TipoPedido = tipoPedido;
        }
    }

}
