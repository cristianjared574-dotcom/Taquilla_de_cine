using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taquilla_de_cine.Boleto
{
   public class BoletoAdultoMayor : boletos
    {
        public string NumCredencialInapam { get; set; }


        public BoletoAdultoMayor(float precio_boleto, string numCredencial) : base(precio_boleto)
        {
           this.NumCredencialInapam = numCredencial;
        }

        public override float calcularPrecioFinal()
        {
            // Aplicar un descuento del 50% para adultos mayores
            return this.precioBoleto * 0.5f;
        }
    }
}
