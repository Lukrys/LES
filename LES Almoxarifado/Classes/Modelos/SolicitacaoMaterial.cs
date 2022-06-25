using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LES_Almoxarifado.Classes.Modelos
{
    class SolicitacaoMaterial
    {
        private ulong Codigo { get; set; }
        private Solicitacao Solicitacao { get; set; }
        private List<Material> Materiais { get; set; }
        private double QuantidadeSolicitada { get; set; }
        private double QuantidadeProvida { get; set; }

        public SolicitacaoMaterial() { }

        public SolicitacaoMaterial(Solicitacao solicitacao) { }

        public SolicitacaoMaterial(Solicitacao solicitacao, List<Material> materiais) { }

    }
}
