using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taquilla_de_cine.Boleto
{
    public abstract class boletos
    {
        public float precioBoleto { get; set; }

        public boletos(float precio_boleto)
        {
            precioBoleto = precio_boleto;
        }

        public abstract float calcularPrecioFinal();
    }

}
