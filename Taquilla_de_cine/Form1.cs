using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Taquilla_de_cine.Boleto;

namespace Taquilla_de_cine
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            boletos Boleto = null;

            string tipoBoleto = cmbTipoBoleto.Text.Trim();

            if (tipoBoleto == "Estudiante")
            {
                
            }
            else if (tipoBoleto == "Adulto Mayor")
            {


            }
            else if (tipoBoleto == "General")
            {
               
            }

            if (Boleto != null)
            {
                float precioFinal = Boleto.calcularPrecioFinal();
                
                lblTotalPagar.Text = "Total a pagar: $" + precioFinal.ToString("0.00");
            }
            else
            {
                MessageBox.Show("Seleccione un tipo de boleto válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return;
            }
             
        }

        private void cmbTipoBoleto_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            lblTotalPagar.Text = "Total a pagar:";
        }
    }
}
