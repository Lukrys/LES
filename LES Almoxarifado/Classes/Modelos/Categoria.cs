using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LES_Almoxarifado.Classes.Modelos
{
    class Categoria
    {
        private ulong Codigo { get; set; }
        private string Descricao { get; set; }

        public Categoria() { }

        public Categoria(ulong codigo, string descricao)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
        }
    }
}
