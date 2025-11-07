using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ciencia_De_Datos_Parcial_2
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }
        // APORTE 1 - Pablo
        public void CalcularPromedios()
        {
            try
            {
                // Se cambió 'float' por 'decimal'
                List<decimal> tasasProvincia = new List<decimal>
                {
                    decimal.Parse(txtProv1.Text),
                    decimal.Parse(txtProv2.Text),
                    decimal.Parse(txtProv3.Text)
                };

                List<decimal> tasasNacion = new List<decimal>
                {
                    decimal.Parse(txtNac1.Text),
                    decimal.Parse(txtNac2.Text),
                    decimal.Parse(txtNac3.Text)
                };

                List<decimal> tasasHipotecario = new List<decimal>
                {
                    decimal.Parse(txtHip1.Text),
                    decimal.Parse(txtHip2.Text),
                    decimal.Parse(txtHip3.Text)
                };

                // Se cambió 'float' por 'decimal'
                decimal promedioProv = CalcularPromedio(tasasProvincia);
                decimal promedioNac = CalcularPromedio(tasasNacion);
                decimal promedioHip = CalcularPromedio(tasasHipotecario);

                lblMensaje.Text = "PROMEDIOS ANUALES:<br/>" +
                                    $"BANCO PROVINCIA: ${promedioProv:F2}<br/>" +
                                    $"BANCO NACION: ${promedioNac:F2}<br/>" +
                                    $"BANCO HIPOTECARIO: ${promedioHip:F2}<br/><br/>";
            }
            catch (FormatException)
            {
                lblMensaje.Text = "ERROR: INGRESE SOLO NUMEROS VALIDOS EN TODAS LAS TASAS.";
            }
        }

        private decimal CalcularPromedio(List<decimal> tasas)
        {
            decimal suma = 0; // Se cambió 'float' por 'decimal'
            foreach (decimal t in tasas) // Se cambió 'float' por 'decimal'
                suma += t;

            // Validación para evitar división por cero si la lista está vacía
            if (tasas.Count == 0)
            {
                return 0;
            }

            return suma / tasas.Count;
        }

        // Aporte 2 - Lucas
        public decimal CalcularAnual(decimal capital, decimal tasaAnualPromedio)
        {
            return capital * (1 + tasaAnualPromedio);
        }

        // Función para la Modalidad 2
        public decimal CalcularTrimestral(decimal capital, decimal tasaAnualPromedio)
        {
            decimal tasaTrimestral = tasaAnualPromedio / 4;
            return capital * (decimal)Math.Pow(1 + (double)tasaTrimestral, 4);
        }

        // Función para la Modalidad 3
        public decimal CalcularMensual(decimal capital, decimal tasaAnualPromedio)
        {
            decimal tasaMensual = tasaAnualPromedio / 12;
            return capital * (decimal)Math.Pow(1 + (double)tasaMensual, 12);
        }

        // Aporte 3 - Alejo
        public void MostrarRendimientosPorAño(decimal[] BP, decimal[] BN, decimal[] BH, string año) //La idea seria que el valor en posicion 0 sea el mes, el 1 el trimestre y el 2 el año
        {
            lblMensaje.Text += año + "<br/>";
            lblMensaje.Text += "Banco Provincia: Mes = " + BP[0] + ", Trimestral = " + BP[1] + ", Anual = " + BP[2] + "<br/>";
            lblMensaje.Text += "Banco Nacion: Mes = " + BN[0] + ", Trimestral = " + BN[1] + ", Anual = " + BN[2] + "<br/>";
            lblMensaje.Text += "Banco Hipotecario: Mes = " + BH[0] + ", Trimestral = " + BH[1] + ", Anual = " + BH[2] + "<br/>";
        }

        // Aporte 5 - Vero
        public void MostrarElMejorBanco(string BancoRecomendado, string OpcionMasRentable, decimal Ganancia)
        {
            lblMensaje.Text += "</br><b>La mejor opción para invertir:</b><br/>";
            lblMensaje.Text += "Banco recomendado -> " + BancoRecomendado + "<br/>";
            lblMensaje.Text += "Opción más rentable  -> " + OpcionMasRentable + "<br/>";
            lblMensaje.Text += "Rendimiento/Ganancia -> " + Ganancia + "<br/>";
        }

        // ℹ️ NOTA: El error IDE1006 es solo una advertencia de estilo sobre
        // el nombre de este método. Puedes ignorarlo o cambiar el nombre a "BtnCalcularInversion_Click".
        protected void btnCalcularInversion_Click(object sender, EventArgs e)
        {
            CalcularPromedios();
            /* EJEMPLO DE COMO SE USARIA (no tengo ni idea de como quieren hacer o divirlo asi que lo hice, cualquier cosa me avisan)
            decimal[] bp = { 1, 2, 3 };
            decimal[] bn = { 4, 5, 6 };
            decimal[] bh = { 7, 8, 9 };
            string año = "2024";

            MostrarRendimientosPorAño(bp, bn, bh, año);
            */

            /*- Cuando tengamos los resultados del mejor banco, los ingresar para que se muestren
             MostrarElMejorBanco(BancoRecomendado, OpcionMasRentable, Ganancia) <-

            -OpcionMasRentable <-se refiere a si es mejor mensual, trimentral, anual (por las dudas)
             */
        }
    }
}