using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LES_Almoxarifado.Classes.Modelos
{
    class EstoqueMaterial
    {
        private ulong Codigo { get; set; }
        private Material Material { get; set; }
        private string CodigoPosicao { get; set; }
        private double QuantidadeAlocada { get; set; }
        private double CustoTotal { get; set; }
        private double CustoUnitario { get; set; }
        private double QuantidadeDisponivel { get; set; }

        public EstoqueMaterial() { }

        public EstoqueMaterial(ulong codigo, Material material, double quantidadeAlocada, double custoTotal)
        {
            this.Codigo = codigo;
            this.Material = material;
            this.QuantidadeAlocada = quantidadeAlocada;
            this.CustoTotal = custoTotal;
            this.CustoUnitario = CustoTotal / quantidadeAlocada;
        }

        public EstoqueMaterial(ulong codigo, Material material, double quantidadeDisponivel)
        {
            this.Codigo = codigo;
            this.Material = material;
            this.QuantidadeDisponivel = quantidadeDisponivel;
        }
    }
}
