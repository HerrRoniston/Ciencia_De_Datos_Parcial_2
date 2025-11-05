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