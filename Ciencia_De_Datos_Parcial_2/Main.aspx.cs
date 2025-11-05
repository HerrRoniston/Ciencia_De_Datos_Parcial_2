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
    }
}