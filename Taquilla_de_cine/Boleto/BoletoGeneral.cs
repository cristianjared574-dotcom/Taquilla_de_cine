using System;

namespace Taquilla_de_cine.Boleto
{
    /// <summary>
    /// Clase que representa el boleto con tarifa estándar sin descuentos
    /// </summary>
    public class BoletoGeneral : boletos
    {
        // Constructor: recibe el precio y lo envía a la clase base
        public BoletoGeneral(float precio_boleto) : base(precio_boleto)
        {
            // No requiere atributos adicionales
        }

        // Implementamos el método abstracto con el mismo nombre y tipo
        public override float calcularPrecioFinal()
        {
            // Devuelve el precio completo sin descuento
            return precioBoleto;
        }
    }
}