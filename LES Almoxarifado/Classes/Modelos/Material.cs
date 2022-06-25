using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LES_Almoxarifado.Classes.Modelos
{
    class Material
    {
        private ulong Codigo { get; set; }
        private Fornecedor Fornecedor { get; set; }
        private Categoria Categoria { get; set; }
        private string Descricao { get; set; }
    
        public Material() { }

        public Material(Fornecedor fornecedor, Categoria categoria, string descricao)
        {
            this.Fornecedor = fornecedor;
            this.Categoria = categoria;
            this.Descricao = descricao;
        }

        public Material(ulong codigo, Fornecedor fornecedor, Categoria categoria, string descricao)
        {
            this.Codigo = codigo;
            this.Fornecedor = fornecedor;
            this.Categoria = categoria;
            this.Descricao = descricao;
        }

    }
}
