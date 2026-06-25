using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taquilla_de_cine.Boleto
{
    /// <summary>
    /// Integrante D: Boleto tarifa general sin descuento
    /// </summary>
    public class BoletoGeneral : boletos
    {
        // Constructor: solo pasa el precio a la clase padre, SIN modificarlo
        public BoletoGeneral(float precio_boleto) : base(precio_boleto)
        {
            // NO agregues nada aquí, así se mantiene el precio correcto
        }

        // Implementación del método: devuelve el precio completo
        public override float calcularPrecioFinal()
        {
            return precioBoleto;
        }
    }
}