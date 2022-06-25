using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LES_Almoxarifado.Classes.Modelos
{
    class Fornecedor
    {
        private ulong Codigo { get; set; }
        private string Desricao { get; set; }

        public Fornecedor() { }

        public Fornecedor(ulong codigo, string descricao)
        {
            this.Codigo = codigo;
            this.Desricao = descricao;
        }
    }
}
