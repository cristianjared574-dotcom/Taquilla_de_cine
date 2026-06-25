using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taquilla_de_cine.Boleto
{
    internal class BoletoEstudiante : boletos
    {
       
        public string Matricula { get; set; }

        public BoletoEstudiante(float precio_base, string matricula) : base(precio_base)
        {
            this.Matricula = matricula;
        }

       
        public override float calcularPrecioFinal()
        {
            
            float descuento = this.precioBoleto * 0.30f;
            return this.precioBoleto - descuento;
        }
    }
}
