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
                // 1️⃣ Convertir los valores ingresados a float y guardarlos en listas
                List<float> tasasProvincia = new List<float>
                {
                    float.Parse(txtProv1.Text),
                    float.Parse(txtProv2.Text),
                    float.Parse(txtProv3.Text)
                };

                List<float> tasasNacion = new List<float>
                {
                    float.Parse(txtNac1.Text),
                    float.Parse(txtNac2.Text),
                    float.Parse(txtNac3.Text)
                };

                List<float> tasasHipotecario = new List<float>
                {
                    float.Parse(txtHip1.Text),
                    float.Parse(txtHip2.Text),
                    float.Parse(txtHip3.Text)
                };

                // 2️⃣ Calcular los promedios
                float promedioProv = CalcularPromedio(tasasProvincia);
                float promedioNac = CalcularPromedio(tasasNacion);
                float promedioHip = CalcularPromedio(tasasHipotecario);

                // 3️⃣ Mostrar los resultados en pantalla
                lblMensaje.Text = "PROMEDIOS ANUALES:<br/>" +
                                  $"BANCO PROVINCIA: {promedioProv:F2}%<br/>" +
                                  $"BANCO NACION: {promedioNac:F2}%<br/>" +
                                  $"BANCO HIPOTECARIO: {promedioHip:F2}%<br/><br/>";
            }
            catch (FormatException)
            {
                lblMensaje.Text = "ERROR: INGRESE SOLO NUMEROS VALIDOS EN TODAS LAS TASAS.";
            }
        }

        private float CalcularPromedio(List<float> tasas)
        {
            float suma = 0;
            foreach (float t in tasas)
                suma += t;
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
        }
    }
}