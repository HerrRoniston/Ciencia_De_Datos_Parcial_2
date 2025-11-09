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
                                    $"BANCO PROVINCIA: {promedioProv:F2}%<br/>" +
                                    $"BANCO NACION: {promedioNac:F2}%<br/>" +
                                    $"BANCO HIPOTECARIO: {promedioHip:F2}%<br/><br/>";
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
            return capital * (1 + tasaAnualPromedio); //se cambia a la cuenta anterior
        }

        // Función para la Modalidad 2
        public decimal CalcularTrimestral(decimal capital, decimal tasaAnualPromedio)
        {
            decimal tasaTrimestral = tasaAnualPromedio / 4; //se cambia a la cuenta anterior
            return capital * (decimal)Math.Pow(1 + (double)tasaTrimestral, 4);
        }

        // Función para la Modalidad 3
        public decimal CalcularMensual(decimal capital, decimal tasaAnualPromedio)
        {
            decimal tasaMensual = tasaAnualPromedio / 12; //se cambia a la cuenta anterior
            return capital * (decimal)Math.Pow(1 + (double)tasaMensual, 12);
        }

        // Aporte 3 - Alejo
        public void MostrarRendimientosPorAño(decimal[] BP, decimal[] BN, decimal[] BH, string año) //La idea seria que el valor en posicion 0 sea el mes, el 1 el trimestre y el 2 el año
        {
            // Obtener el capital inicial desde el TextBox
            decimal capitalInicial = 0;
            if (!decimal.TryParse(txtMonto.Text, out capitalInicial))
            {
                lblMensaje.Text += "<br/>❌ Error: El capital ingresado no es válido.<br/>";
                return;
            }

            // Mostrar los rendimientos compuestos (mensual, trimestral, anual)
            lblMensaje.Text += $"<br/><b>Rendimientos obtenidos ({año}):</b><br/>";
            lblMensaje.Text += $"Banco Provincia: Mes = {BP[0]:F2}# Trimestral = {BP[1]:F2}# Anual = {BP[2]:F2}<br/>";
            lblMensaje.Text += $"Banco Nación: Mes = {BN[0]:F2}# Trimestral = {BN[1]:F2}# Anual = {BN[2]:F2}<br/>";
            lblMensaje.Text += $"Banco Hipotecario: Mes = {BH[0]:F2}# Trimestral = {BH[1]:F2}# Anual = {BH[2]:F2}<br/><br/>";

            // Calcular las ganancias totales al finalizar el año (reinversión incluida)
            decimal gananciaProvincia = BP[2] - capitalInicial;
            decimal gananciaNacion = BN[2] - capitalInicial;
            decimal gananciaHipotecario = BH[2] - capitalInicial;

            // Mostrar resumen de ganancias
            //lblMensaje.Text += "<b>Resumen de ganancias al finalizar el año:</b><br/>";
            //lblMensaje.Text += $"Banco Provincia → Ganancia total: ${gananciaProvincia:F2}<br/>";
            //lblMensaje.Text += $"Banco Nación → Ganancia total: ${gananciaNacion:F2}<br/>";
            //lblMensaje.Text += $"Banco Hipotecario → Ganancia total: ${gananciaHipotecario:F2}<br/><br/>";
        }

        // Aporte 5 - Vero
        public void MostrarElMejorBanco(string BancoRecomendado, string OpcionMasRentable, decimal Ganancia)
        {
            lblMensaje.Text += "</br><b>La mejor opción para invertir:</b><br/>";
            lblMensaje.Text += "Banco recomendado -> " + BancoRecomendado + "<br/>";
            lblMensaje.Text += "Opción más rentable  -> " + OpcionMasRentable + "<br/>";
            lblMensaje.Text += "Rendimiento/Ganancia -> " + Ganancia.ToString("F2") + "<br/>";//se corrige para mostrar dos decimales solamente en resultado (RL)
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

            // Aporte 4 - Rosaura Limache (RL)
            try
            {
                decimal capital = decimal.Parse(txtMonto.Text);

                // Promedios (ya calculados en CalcularPromedios)
                decimal promedioProv = CalcularPromedio(new List<decimal> {
            decimal.Parse(txtProv1.Text),
            decimal.Parse(txtProv2.Text),
            decimal.Parse(txtProv3.Text)
        }) / 100;

                decimal promedioNac = CalcularPromedio(new List<decimal> {
            decimal.Parse(txtNac1.Text),
            decimal.Parse(txtNac2.Text),
            decimal.Parse(txtNac3.Text)
        }) / 100;

                decimal promedioHip = CalcularPromedio(new List<decimal> {
            decimal.Parse(txtHip1.Text),
            decimal.Parse(txtHip2.Text),
            decimal.Parse(txtHip3.Text)
        }) / 100;

                // Cálculos de inversión por modalidad
                //restamos porque el rendimiento es la diferencia que te da el banco de tu capital inicial
                decimal provAnual = CalcularAnual(capital, promedioProv)-capital;
                decimal provTrim = CalcularTrimestral(capital, promedioProv)-capital;
                decimal provMens = CalcularMensual(capital, promedioProv)-capital;

                decimal nacAnual = CalcularAnual(capital, promedioNac)-capital;
                decimal nacTrim = CalcularTrimestral(capital, promedioNac)-capital;
                decimal nacMens = CalcularMensual(capital, promedioNac)-capital;

                decimal hipAnual = CalcularAnual(capital, promedioHip)-capital;
                decimal hipTrim = CalcularTrimestral(capital, promedioHip) - capital;
                decimal hipMens = CalcularMensual(capital, promedioHip) - capital;

                // Mostrar rendimientos por banco
                lblMensaje.Text += "<br/><b>Rendimientos obtenidos:</b><br/>";
                MostrarRendimientosPorAño(
                    new decimal[] { provMens, provTrim, provAnual },
                    new decimal[] { nacMens, nacTrim, nacAnual },
                    new decimal[] { hipMens, hipTrim, hipAnual },
                    "Rendimiento estimado");

                // Determinar el mejor banco y modalidad
                Dictionary<string, decimal> rendimientos = new Dictionary<string, decimal>
        {
            { "Provincia - Mensual", provMens },
            { "Provincia - Trimestral", provTrim },
            { "Provincia - Anual", provAnual },
            { "Nación - Mensual", nacMens },
            { "Nación - Trimestral", nacTrim },
            { "Nación - Anual", nacAnual },
            { "Hipotecario - Mensual", hipMens },
            { "Hipotecario - Trimestral", hipTrim },
            { "Hipotecario - Anual", hipAnual }
        };

                var mejor = rendimientos.OrderByDescending(r => r.Value).First();

                // Dividir banco y modalidad para mostrarlos
                string[] partes = mejor.Key.Split('-');
                string banco = partes[0].Trim();
                string modalidad = partes[1].Trim();

                
                decimal ganancia = mejor.Value; //no hace falta restar porque anteriormente se hizo

                MostrarElMejorBanco(banco, modalidad, ganancia);
            }
            catch
            {
                lblMensaje.Text = "ERROR: Revise los valores ingresados.";
            }

        }
    }
}