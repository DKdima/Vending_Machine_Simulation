using System;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Policy;

namespace vendingDmytroKosanyakVoloshyn
{
    public partial class maquina_vending : Form
    {
        private decimal monedasAcumuladas = 0.0m;
        private int estado = 0;
        private string bebida = " ";
        private decimal bebida_cantidad = 0.0m;
        private string idioma = "es";
        private Boolean tpv = false;


        public maquina_vending()
        {
            InitializeComponent();
            // Obtiene la ruta base del directorio de la aplicación
            string rutaBase = Application.StartupPath;
            // Define la ubicación relativa del archivo de ayuda
            string nombreArchivo = "es.html";
            // Combina la ruta base con la ubicación relativa del archivo de ayuda
            string rutaCompleta = Path.Combine(rutaBase, nombreArchivo);
            // Asigna la ruta de ayuda al proveedor de ayuda
            helpProvider1.HelpNamespace = rutaCompleta;
            AplicarEstiloFuenteDigital7();

        }
           private void AplicarEstiloFuenteDigital7()
        {
            if (FuenteDigital7Disponible())
            {
                l_columna1.Font = new Font("Digital-7", 17, FontStyle.Regular);
                l_columna2.Font = new Font("Digital-7", 17, FontStyle.Regular);
                l_columna3.Font = new Font("Digital-7", 17, FontStyle.Regular);
                l_monedas.Font = new Font("Digital-7", 17, FontStyle.Regular);
                l_cocacola.Font = new Font("Digital-7", 17, FontStyle.Regular);
                l_fantalimon.Font = new Font("Digital-7", 17, FontStyle.Regular);
                l_fantanaranja.Font = new Font("Digital-7", 17, FontStyle.Regular);
                l_jack.Font = new Font("Digital-7", 17, FontStyle.Regular);
            }
            else
            {
                l_columna1.Font = new Font("Arial", 12, FontStyle.Regular);
                l_columna2.Font = new Font("Arial", 12, FontStyle.Regular);
                l_columna3.Font = new Font("Arial", 12, FontStyle.Regular);
                l_monedas.Font = new Font("Arial", 12, FontStyle.Regular);
                l_cocacola.Font = new Font("Arial", 12, FontStyle.Regular);
                l_fantalimon.Font = new Font("Arial", 12, FontStyle.Regular);
                l_fantanaranja.Font = new Font("Arial", 12, FontStyle.Regular);
                l_jack.Font = new Font("Arial", 12, FontStyle.Regular);
            }
        }

        private bool FuenteDigital7Disponible()
        {
            FontFamily[] fontFamilies = FontFamily.Families;

            foreach (FontFamily fontFamily in fontFamilies)
            {
                if (fontFamily.Name.Equals("Digital-7", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }
            private void Form1_Load(object sender, EventArgs e)
        {
            // Inicializar la interfaz en el Estado1 inicial
            SetEstadoInicial();

        }

        // Evento Click del botón de 50 céntimos
        private void b_50_Click(object sender, EventArgs e)
        {
            monedasAcumuladas += 0.50m;
            ActualizarEstado();
        }

        // Evento Click del botón de 1 euro
        private void b_1_Click(object sender, EventArgs e)
        {
            monedasAcumuladas += 1.00m;
            ActualizarEstado();
        }

        // Evento Click del botón de 2 euros
        private void b_2_Click(object sender, EventArgs e)
        {
            monedasAcumuladas += 2.00m;
            ActualizarEstado();
        }

        private void b_tpv_Click(object sender, EventArgs e)
        {
            monedasAcumuladas += 4.00m;
            tpv = true;
            ActualizarEstado();
        }

        // Evento Click del botón de cancelar
        private void b_cancel_Click(object sender, EventArgs e)
        {
            if (tpv == true)
            {
                SetEstadoInicial();
            }
            else {
                SetEstadoCancel();
            }
            
        }
        // Evento Click del botón retirar monedas
        private void b_retirarmonedas_Click(object sender, EventArgs e)
        {   
            if (estado == 3)
            {
                SetEstadoInicial();
            }
            else
            {
                SetEstadoRetirarBebida();
            }

        }
        // Evento Click del botón cocacola
        private void b_cocacola_Click(object sender, EventArgs e)
        {
            monedasAcumuladas -= 1.50m;
            bebida_cantidad = 1.50m;
            bebida = "coca";
            if (tpv == true)
            {
                SetEstadoRetirarBebida();
            }
            else
            if (monedasAcumuladas == 0)
            {
                SetEstadoRetirarBebida();
            }
            else
                SetEstadoRetirarMonedasConBebida();
        }
        // Evento Click del botón fantalimón
        private void b_fantalimon_Click(object sender, EventArgs e)
        {
            monedasAcumuladas -= 1.50m;
            bebida_cantidad = 1.50m;
            bebida = "limon";
            if (tpv == true)
            {
                SetEstadoRetirarBebida();
            }
            else
            if (monedasAcumuladas == 0)
            {
                SetEstadoRetirarBebida();
            }
            else
                SetEstadoRetirarMonedasConBebida();
        }
        // Evento Click del botón fantanaranja
        private void b_fantanaranja_Click(object sender, EventArgs e)
        {
            monedasAcumuladas -= 1.50m;
            bebida_cantidad = 1.50m;
            bebida = "naranja";
            if (tpv == true)
            {
                SetEstadoRetirarBebida();
            }
            else
            if (monedasAcumuladas == 0)
            {
                SetEstadoRetirarBebida();
            }
            else
                SetEstadoRetirarMonedasConBebida();
        }
        // Evento Click del botón jack
        private void b_jack_Click(object sender, EventArgs e)
        {
            monedasAcumuladas -= 4m;
            bebida_cantidad = 4m;
            bebida = "jack";
            if (tpv == true)
            {
                SetEstadoRetirarBebida();
            }
            else if (monedasAcumuladas == 0)
            {
                SetEstadoRetirarBebida();
            }
            else
                SetEstadoRetirarMonedasConBebida();
        }
        // Evento Click del botón Retirar Monedas
        private void b_retirarbebida_Click(object sender, EventArgs e)
        {
            SetEstadoInicial();
        }

        // Evento Click de botones de Idiomas
        private void b_es_Click(object sender, EventArgs e)
        {
            

            idioma = "es";
            toolTip1.SetToolTip(b_en, "Click para traducir al Inglés");
            helpProvider1.SetHelpString(b_50, "Click para añadir 0,50€");
            helpProvider1.SetHelpString(b_1, "Click para añadir 1€");
            helpProvider1.SetHelpString(b_2, "Click para añadir 2€");
            helpProvider1.SetHelpString(b_tpv, "Click para añadir 4€");
            helpProvider1.SetHelpString(b_cancel, "Click para cancelar");
            helpProvider1.SetHelpString(b_retirarmonedas, "Click para retirar monedas");
            helpProvider1.SetHelpString(b_retirarbebida, "Click para retirar bebida");


            switch (estado)
            {
                case 1:
                    SetEstadoInicial();
                    break;
                case 2:
                    SetEstadoNoBebida();
                    break;
                case 3:
                    SetEstadoCancel();
                    break;
                case 4:
                    SetEstadoEstandar();
                    break;
                case 5:
                    SetEstadoPremium();
                    break;
                case 6:
                    SetEstadoRetirarMonedasConBebida();
                    break;
                case 7:
                    SetEstadoRetirarBebida();
                    break;
            }
        }

        private void b_en_Click(object sender, EventArgs e)
        {

            idioma = "en";
            
            toolTip1.SetToolTip(b_en, "Click to translate to English");
            helpProvider1.SetHelpString(b_50, "Click to add 0,50€");
            helpProvider1.SetHelpString(b_1, "Click to add 1€");
            helpProvider1.SetHelpString(b_2, "Click to add 2€");
            helpProvider1.SetHelpString(b_tpv, "Click to add 4€");
            helpProvider1.SetHelpString(b_cancel, "Click to cancel");
            helpProvider1.SetHelpString(b_retirarmonedas, "Click to remove coins");
            helpProvider1.SetHelpString(b_retirarbebida, "Click to remove beverage");
            switch (estado)
            {
                case 1:
                    SetEstadoInicial();
                    break;
                case 2:
                    SetEstadoNoBebida();
                    break;
                case 3:
                    SetEstadoCancel();
                    break;
                case 4:
                    SetEstadoEstandar();
                    break;
                case 5:
                    SetEstadoPremium();
                    break;
                case 6:
                    SetEstadoRetirarMonedasConBebida();
                    break;
                case 7:
                    SetEstadoRetirarBebida();
                    break;
            }

        }

        // Función para actualizar el estado de la interfaz según la cantidad de monedas acumuladas
        private void ActualizarEstado()
        {
            l_monedas.Text = monedasAcumuladas.ToString("0.00");


            if (monedasAcumuladas < 1.50m)
            {
                // Estado2 noBebida
                SetEstadoNoBebida();
            }
            else if (monedasAcumuladas < 4.00m)
            {
                // Estado4 estandar
                SetEstadoEstandar();
            }
            else
            {
                // Estado5 premium
                SetEstadoPremium();
            }
        }

   

        // Funciones para establecer Estados

        private void SetEstadoInicial()
        {
            // Implementa la lógica para el Estado1 inicial
            if (idioma == "en")
            {
                l_columna1.Text = "1 INSERT COIN";
                l_columna2.Text = "";
                l_columna3.Text = "";
                b_es.Enabled = true;
                b_es.BackgroundImage = Properties.Resources.es;
                b_en.Enabled = false;
                b_en.BackgroundImage = Properties.Resources.en1;
                toolTip1.SetToolTip(b_en, "Click to translate to English");
                helpProvider1.SetHelpString(b_50, "Click to add 0,50€");
                helpProvider1.SetHelpString(b_1, "Click to add 1€");
                helpProvider1.SetHelpString(b_2, "Click to add 2€");
                helpProvider1.SetHelpString(b_tpv, "Click to add 4€");
                helpProvider1.SetHelpString(b_cancel, "Click to cancel");
                helpProvider1.SetHelpString(b_retirarmonedas, "Click to remove coins");
                helpProvider1.SetHelpString(b_retirarbebida, "Click to remove beverage");
            }
            else
            {
                l_columna1.Text = "1 INSERTE MONEDA";
                l_columna2.Text = "";
                l_columna3.Text = "";
                b_es.Enabled = false;
                b_es.BackgroundImage = Properties.Resources.es1;
                b_en.Enabled = true;
                b_en.BackgroundImage = Properties.Resources.en;
                toolTip1.SetToolTip(b_en, "Click para traducir al Inglés");
                helpProvider1.SetHelpString(b_50, "Click para añadir 0,50€");
                helpProvider1.SetHelpString(b_1, "Click para añadir 1€");
                helpProvider1.SetHelpString(b_2, "Click para añadir 2€");
                helpProvider1.SetHelpString(b_tpv, "Click para añadir 4€");
                helpProvider1.SetHelpString(b_cancel, "Click para cancelar");
                helpProvider1.SetHelpString(b_retirarmonedas, "Click para retirar monedas");
                helpProvider1.SetHelpString(b_retirarbebida, "Click para retirar bebida");

            }
            monedasAcumuladas = 0.0m;
            bebida_cantidad = 0.0M;
            bebida = "";
            b_tpv.Enabled = true;
            b_tpv.BackgroundImage = Properties.Resources.tpv;
            b_tpv.FlatAppearance.BorderSize = 0;
            tpv = false;
            b_50.Enabled = true;
            b_50.BackgroundImage = Properties.Resources.Cents_euro_50;
            b_1.Enabled = true;
            b_1.BackgroundImage = Properties.Resources.Euro_1;
            b_2.Enabled = true;
            b_2.BackgroundImage = Properties.Resources.Euro_2;
            l_monedas.Text = "0,00";
            b_cancel.Enabled = false;
            b_cancel.BackColor = Color.Gray;
            b_retirarmonedas.Enabled = false;
            b_retirarmonedas.BackgroundImage = null;
            b_cocacola.Enabled = false;
            b_cocacola.BackgroundImage = Properties.Resources.Coca_Cola1;
            l_cocacola.Text = "    ";
            b_fantalimon.Enabled = false;
            b_fantalimon.BackgroundImage = Properties.Resources.Fanta_Lemon1;
            l_fantalimon.Text = "    ";
            b_fantanaranja.Enabled = false;
            b_fantanaranja.BackgroundImage = Properties.Resources.Fanta_Orange1;
            l_fantanaranja.Text = "    ";
            b_jack.Enabled = false;
            b_jack.BackgroundImage = Properties.Resources.Jack_Daniel_s_Cola_Cola1;
            l_jack.Text = "    ";
            b_retirarbebida.Enabled = false;
            b_retirarbebida.BackgroundImage = null;
            estado = 1;
        }

        private void SetEstadoNoBebida()
        {
            // Implementa la lógica para el Estado2 noBebida
            if (idioma == "en")
            {
                l_columna1.Text = "1 INSERT COIN";
                l_columna2.Text = "";
                l_columna3.Text = "";
                b_es.Enabled = true;
                b_es.BackgroundImage = Properties.Resources.es;
                b_en.Enabled = false;
                b_en.BackgroundImage = Properties.Resources.en1;
            }
            else
            {
                l_columna1.Text = "1 INSERTE MONEDA";
                l_columna2.Text = "";
                l_columna3.Text = "";
                b_es.Enabled = false;
                b_es.BackgroundImage = Properties.Resources.es1;
                b_en.Enabled = true;
                b_en.BackgroundImage = Properties.Resources.en;
            }
            b_tpv.Enabled = false;
            b_tpv.BackgroundImage = Properties.Resources.tpv;
            b_tpv.FlatAppearance.BorderColor = Color.Red;
            b_tpv.FlatAppearance.BorderSize = 3; // Ancho del borde en píxeles
            b_tpv.FlatStyle = FlatStyle.Flat;
            b_50.Enabled = true;
            b_1.Enabled = true;
            b_2.Enabled = true;
            l_monedas.Text = "" + monedasAcumuladas;
            b_cancel.Enabled = true;
            b_cancel.BackColor = Color.Red;
            b_retirarmonedas.Enabled = false;
            b_retirarmonedas.BackgroundImage = null;
            b_cocacola.Enabled = false;
            b_cocacola.BackgroundImage = Properties.Resources.Coca_Cola1;
            l_cocacola.Text = "    ";
            b_fantalimon.Enabled = false;
            b_fantalimon.BackgroundImage = Properties.Resources.Fanta_Lemon1;
            l_fantalimon.Text = "    ";
            b_fantanaranja.Enabled = false;
            b_fantanaranja.BackgroundImage = Properties.Resources.Fanta_Orange1;
            l_fantanaranja.Text = "    ";
            b_jack.Enabled = false;
            b_jack.BackgroundImage = Properties.Resources.Jack_Daniel_s_Cola_Cola1;
            l_jack.Text = "    ";
            b_retirarbebida.Enabled = false;
            estado = 2;

        }

        private void SetEstadoCancel()
        {
            // Implementa la lógica para el Estado3 cancel
            if (idioma == "en")
            {
                l_columna1.Text = "1 REMOVE COINS: " + monedasAcumuladas + "€";
                l_columna2.Text = "";
                l_columna3.Text = "";
                b_es.Enabled = true;
                b_es.BackgroundImage = Properties.Resources.es;
                b_en.Enabled = false;
                b_en.BackgroundImage = Properties.Resources.en1;
            }
            else
            {
                l_columna1.Text = "1 RETIRE MONEDAS: " + monedasAcumuladas + "€";
                l_columna2.Text = "";
                l_columna3.Text = "";
                b_es.Enabled = false;
                b_es.BackgroundImage = Properties.Resources.es1;
                b_en.Enabled = true;
                b_en.BackgroundImage = Properties.Resources.en;
            }
            b_tpv.Enabled = false;
            b_tpv.BackgroundImage = Properties.Resources.tpv;
            b_tpv.FlatAppearance.BorderColor = Color.Red;
            b_tpv.FlatAppearance.BorderSize = 3; // Ancho del borde en píxeles
            b_tpv.FlatStyle = FlatStyle.Flat;
            b_50.Enabled = false;
            b_50.BackgroundImage = Properties.Resources.Cents_euro_501;
            b_1.Enabled = false;
            b_1.BackgroundImage = Properties.Resources.Euro_11;
            b_2.Enabled = false;
            b_2.BackgroundImage = Properties.Resources.Euro_21;
            l_monedas.Text = "    ";
            b_cancel.Enabled = false;
            b_cancel.BackColor = Color.Gray;
            b_retirarmonedas.Enabled = true;
            b_retirarmonedas.BackgroundImage = Properties.Resources.retirar_Monedas;
            b_cocacola.Enabled = false;
            b_cocacola.BackgroundImage = Properties.Resources.Coca_Cola1;
            l_cocacola.Text = "    ";
            b_fantalimon.Enabled = false;
            b_fantalimon.BackgroundImage = Properties.Resources.Fanta_Lemon1;
            l_fantalimon.Text = "    ";
            b_fantanaranja.Enabled = false;
            b_fantanaranja.BackgroundImage = Properties.Resources.Fanta_Orange1;
            l_fantanaranja.Text = "    ";
            b_jack.Enabled = false;
            b_jack.BackgroundImage = Properties.Resources.Jack_Daniel_s_Cola_Cola1;
            l_jack.Text = "    ";
            b_retirarbebida.Enabled = false;
            estado = 3;
        }

        private void SetEstadoEstandar()
        {
            // Implementa la lógica para el Estado4 estandar
            if (idioma == "en")
            {
                l_columna1.Text = "1 INSERT COIN";
                l_columna2.Text = "2 CHOOSE BEVERAGE";
                l_columna3.Text = "";
                b_es.Enabled = true;
                b_es.BackgroundImage = Properties.Resources.es;
                b_en.Enabled = false;
                b_en.BackgroundImage = Properties.Resources.en1;
            }
            else
            {
                l_columna1.Text = "1 INSERTE MONEDA";
                l_columna2.Text = "2 ELIJA BEBIDA";
                l_columna3.Text = "";
                b_es.Enabled = false;
                b_es.BackgroundImage = Properties.Resources.es1;
                b_en.Enabled = true;
                b_en.BackgroundImage = Properties.Resources.en;
            }
            b_tpv.Enabled = false;
            b_tpv.BackgroundImage = Properties.Resources.tpv;
            b_tpv.FlatAppearance.BorderColor = Color.Red;
            b_tpv.FlatAppearance.BorderSize = 3; // Ancho del borde en píxeles
            b_tpv.FlatStyle = FlatStyle.Flat;
            b_50.Enabled = true;
            b_1.Enabled = true;
            b_2.Enabled = true;
            l_monedas.Text = "" + monedasAcumuladas;
            b_cancel.Enabled = true;
            b_cancel.BackColor = Color.Red;
            b_retirarmonedas.Enabled = false;
            b_retirarmonedas.BackgroundImage = null;
            b_cocacola.Enabled = true;
            b_cocacola.BackgroundImage = Properties.Resources.Coca_Cola;
            l_cocacola.Text = "1,50";
            b_fantalimon.Enabled = true;
            b_fantalimon.BackgroundImage = Properties.Resources.Fanta_Lemon;
            l_fantalimon.Text = "1,50";
            b_fantanaranja.Enabled = true;
            b_fantanaranja.BackgroundImage = Properties.Resources.Fanta_Orange;
            l_fantanaranja.Text = "1,50";
            b_jack.Enabled = false;
            b_jack.BackgroundImage = Properties.Resources.Jack_Daniel_s_Cola_Cola1;
            l_jack.Text = "    ";
            b_retirarbebida.Enabled = false;
            estado = 4;
        }

        private void SetEstadoPremium()
        {
            // Implementa la lógica para el Estado5 premium
            if (idioma == "en")
            {
                l_columna1.Text = "";
                l_columna2.Text = "2 CHOOSE BEVERAGE";
                l_columna3.Text = "";
                b_es.Enabled = true;
                b_es.BackgroundImage = Properties.Resources.es;
                b_en.Enabled = false;
                b_en.BackgroundImage = Properties.Resources.en1;
            }
            else
            {
                l_columna1.Text = "";
                l_columna2.Text = "2 ELIJA BEBIDA";
                l_columna3.Text = "";
                b_es.Enabled = false;
                b_es.BackgroundImage = Properties.Resources.es1;
                b_en.Enabled = true;
                b_en.BackgroundImage = Properties.Resources.en;
            }
            b_tpv.Enabled = false;
            b_tpv.BackgroundImage = Properties.Resources.tpv;
            b_tpv.FlatAppearance.BorderColor = Color.Red;
            b_tpv.FlatAppearance.BorderSize = 3; // Ancho del borde en píxeles
            b_tpv.FlatStyle = FlatStyle.Flat;
            b_50.Enabled = false;
            b_50.BackgroundImage = Properties.Resources.Cents_euro_501;
            b_1.Enabled = false;
            b_1.BackgroundImage = Properties.Resources.Euro_11;
            b_2.Enabled = false;
            b_2.BackgroundImage = Properties.Resources.Euro_21;
            l_monedas.Text = "" + monedasAcumuladas;
            b_cancel.Enabled = true;
            b_cancel.BackColor = Color.Red;
            b_retirarmonedas.Enabled = false;
            b_retirarmonedas.BackgroundImage = null;
            b_cocacola.Enabled = true;
            b_cocacola.BackgroundImage = Properties.Resources.Coca_Cola;
            l_cocacola.Text = "1,50";
            b_fantalimon.Enabled = true;
            b_fantalimon.BackgroundImage = Properties.Resources.Fanta_Lemon;
            l_fantalimon.Text = "1,50";
            b_fantanaranja.Enabled = true;
            b_fantanaranja.BackgroundImage = Properties.Resources.Fanta_Orange;
            l_fantanaranja.Text = "1,50";
            b_jack.Enabled = true;
            b_jack.BackgroundImage = Properties.Resources.Jack_Daniel_s_Coca_Cola;
            l_jack.Text = "4,00";
            b_retirarbebida.Enabled = false;
            estado = 5;
        }
        private void SetEstadoRetirarMonedasConBebida()
        {
            // Implementa la lógica para el Estado6 Retirar Monedas (Para pasar a retirar la bebida)
            if (idioma == "en")
            {
                l_columna1.Text = "1 REMOVE CHANGE: " + monedasAcumuladas + "€";
                l_columna2.Text = "";
                l_columna3.Text = "";
                b_es.Enabled = true;
                b_es.BackgroundImage = Properties.Resources.es;
                b_en.Enabled = false;
                b_en.BackgroundImage = Properties.Resources.en1;
            }
            else
            {
                l_columna1.Text = "1 RETIRE CAMBIO: " + monedasAcumuladas + "€";
                l_columna2.Text = "";
                l_columna3.Text = "";
                b_es.Enabled = false;
                b_es.BackgroundImage = Properties.Resources.es1;
                b_en.Enabled = true;
                b_en.BackgroundImage = Properties.Resources.en;
            }
            b_tpv.Enabled = false;
            b_tpv.BackgroundImage = Properties.Resources.tpv;
            b_tpv.FlatAppearance.BorderColor = Color.Red;
            b_tpv.FlatAppearance.BorderSize = 3; // Ancho del borde en píxeles
            b_tpv.FlatStyle = FlatStyle.Flat;
            b_50.Enabled = false;
            b_50.BackgroundImage = Properties.Resources.Cents_euro_501;
            b_1.Enabled = false;
            b_1.BackgroundImage = Properties.Resources.Euro_11;
            b_2.Enabled = false;
            b_2.BackgroundImage = Properties.Resources.Euro_21;
            l_monedas.Text = "    ";
            b_cancel.Enabled = false;
            b_cancel.BackColor = Color.Gray;
            b_retirarmonedas.Enabled = true;
            b_retirarmonedas.BackgroundImage = Properties.Resources.retirar_Monedas;
            b_cocacola.Enabled = false;
            b_cocacola.BackgroundImage = Properties.Resources.Coca_Cola1;
            l_cocacola.Text = "    ";
            b_fantalimon.Enabled = false;
            b_fantalimon.BackgroundImage = Properties.Resources.Fanta_Lemon1;
            l_fantalimon.Text = "    ";
            b_fantanaranja.Enabled = false;
            b_fantanaranja.BackgroundImage = Properties.Resources.Fanta_Orange1;
            l_fantanaranja.Text = "    ";
            b_jack.Enabled = false;
            b_jack.BackgroundImage = Properties.Resources.Jack_Daniel_s_Cola_Cola1;
            l_jack.Text = "    ";
            b_retirarbebida.Enabled = false;
            estado = 6;
        }


        private void SetEstadoRetirarBebida()
        {
            // Implementa la lógica para el Estado7 Retirar Bebida
            if (idioma == "en")
            {
                if (tpv == true)
                {
                    l_columna1.Text = "HAS BEEN CHARGED: "+bebida_cantidad+"€";
                }
                else
                {
                    l_columna1.Text = "";
                }
                l_columna2.Text = "";
                l_columna3.Text = "3 TAKE BEVERAGE";
                b_es.Enabled = true;
                b_es.BackgroundImage = Properties.Resources.es;
                b_en.Enabled = false;
                b_en.BackgroundImage = Properties.Resources.en1;
            }
            else
            {
                if (tpv == true)
                {
                    l_columna1.Text = "SE HA CARGADO: "+bebida_cantidad+"€";
                }
                else
                {
                    l_columna1.Text = "";
                }
                l_columna2.Text = "";
                l_columna3.Text = "3 TOMA LA BEBIDA";
                b_es.Enabled = false;
                b_es.BackgroundImage = Properties.Resources.es1;
                b_en.Enabled = true;
                b_en.BackgroundImage = Properties.Resources.en;
            }
            b_tpv.Enabled = false;
            b_tpv.BackgroundImage = Properties.Resources.tpv;
            b_tpv.FlatAppearance.BorderColor = Color.Red;
            b_tpv.FlatAppearance.BorderSize = 3; // Ancho del borde en píxeles
            b_tpv.FlatStyle = FlatStyle.Flat;
            b_50.Enabled = false;
            b_50.BackgroundImage = Properties.Resources.Cents_euro_501;
            b_1.Enabled = false;
            b_1.BackgroundImage = Properties.Resources.Euro_11;
            b_2.Enabled = false;
            b_2.BackgroundImage = Properties.Resources.Euro_21;
            l_monedas.Text = "    ";
            b_cancel.Enabled = false;
            b_cancel.BackColor = Color.Gray;
            b_retirarmonedas.Enabled = false;
            b_retirarmonedas.BackgroundImage = null;
            b_cocacola.Enabled = false;
            b_cocacola.BackgroundImage = Properties.Resources.Coca_Cola1;
            l_cocacola.Text = "    ";
            b_fantalimon.Enabled = false;
            b_fantalimon.BackgroundImage = Properties.Resources.Fanta_Lemon1;
            l_fantalimon.Text = "    ";
            b_fantanaranja.Enabled = false;
            b_fantanaranja.BackgroundImage = Properties.Resources.Fanta_Orange1;
            l_fantanaranja.Text = "    ";
            b_jack.Enabled = false;
            b_jack.BackgroundImage = Properties.Resources.Jack_Daniel_s_Cola_Cola1;
            l_jack.Text = "    ";
            b_retirarbebida.Enabled = true;
            estado = 7;

            switch (bebida)
            {
                case "coca":
                    b_retirarbebida.BackgroundImage = Properties.Resources.Coca_Cola;
                    break;
                case "limon":
                    b_retirarbebida.BackgroundImage = Properties.Resources.Fanta_Lemon;
                    break;
                case "naranja":
                    b_retirarbebida.BackgroundImage = Properties.Resources.Fanta_Orange;
                    break;
                case "jack":
                    b_retirarbebida.BackgroundImage = Properties.Resources.Jack_Daniel_s_Coca_Cola;
                    break;
            }
        }

    }
}
