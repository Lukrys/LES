using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LES_Almoxarifado.Classes.Modelos
{
    class Permissoes
    {
        private ulong Codigo { get; set; }
        private string Descricao { get; set; }
        
        Dictionary<string, bool> PermissoesInventarios;
        Dictionary<string, bool> PermissoesOrdensCompra;
        Dictionary<string, bool> PermissoesPedidos;
        Dictionary<string, bool> PermissoesMateriais;
        Dictionary<string, bool> PermissoesUsuarios;
        Dictionary<string, bool> PermissoesFuncionarios;
        Dictionary<string, bool> PermissoesFornecedores;

        public Permissoes() { }

        public Permissoes(string descricao)
        {
            this.Descricao = descricao;
        }

        public Permissoes(ulong codigo, string descricao)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
        }

    }
}
