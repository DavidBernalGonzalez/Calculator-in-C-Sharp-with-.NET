using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraII
{
    public partial class FormMain : Form
    {
        //VARIABLES SCOOPE GLOBAL
        //----------------------------------------------------------------
        double total1;
        double total2;
        bool suma = false;
        bool resta = false;
        bool division = false;
        bool multiplicacion = false;
        //CONSTRUCTOR
        //----------------------------------------------------------------
        public FormMain()
        {
            InitializeComponent();
            display.Clear();
        }
        //FUNCTIONS
        //----------------------------------------------------------------
        private void sumar()
        {
            //Si la pantalla no está vacía
            if (display.Text != "")
            {
                total1 = total1 + double.Parse(display.Text);
                display.Clear();
                suma = true;
                resta = false;
                multiplicacion = false;
                division = false;
            }
            else
            {
                error();
            }
        }

        private void restar()
        {
            if (display.Text != "")
            {
                total1 = total1 + double.Parse(display.Text);
                display.Clear();
                suma = false;
                resta = true;
                multiplicacion = false;
                division = false;
            }
            else
            {
                error();
            }
        }

        private void multiplicar()
        {
            if (display.Text != "")
            {
                total1 = total1 + double.Parse(display.Text);
                display.Clear();
                suma = false;
                resta = false;
                multiplicacion = true;
                division = false;
            }
            else
            {
                error();
            }
        }

        private void dividir()
        {
            if (display.Text != "")
            {
                total1 = total1 + double.Parse(display.Text); //total1 = total1 + pantalla
                display.Clear(); //limpio la pantalla
                suma = false;
                resta = false;
                multiplicacion = false;
                division = true;//indico que es una division

            }
            else
            {
                error();
            }
        }

        private void error()
        {
            MessageBox.Show("Introduce un número y pulsa un operador", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            reset();
        }

        private void eliminarDigito()
        {
            if (display.Text.Length > 1)
            {
                string texto = display.Text;
                display.Text = texto.Substring(0, texto.Length - 1);
            }
            else if (display.Text.Length == 1)
            {
                reset();
            }
            else
            {
                MessageBox.Show("Si no hay números, no puedes eliminar nada", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void igualar()
        {
            if (suma == true && display.Text != "")
            {
                total2 = total1 + double.Parse(display.Text);
                display.Text = total2.ToString();
                total1 = 0;
            }
            else if (resta == true && display.Text != "")
            {
                total2 = total1 - double.Parse(display.Text);
                display.Text = total2.ToString();
                total1 = 0;
            }
            else if (multiplicacion == true && display.Text != "")
            {
                total2 = total1 * double.Parse(display.Text);
                display.Text = total2.ToString();
                total1 = 0;
            }
            else if (division == true && display.Text != "")
            {
                total2 = total1 / double.Parse(display.Text);
                display.Text = total2.ToString();
                total1 = 0;
            }
            //si pulsas un simbolo y después = sin introducir un número, mostramos un mensaje y reseteamos la calculadora 
            else
            {
                MessageBox.Show("No has introducido un número, reseteando calculadora", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reset();
            }
            suma = false;
            resta = false;
            division = false;
            multiplicacion = false;
        }

        private void addTxt(String value)
        {
            display.Text = display.Text + value;
            ActiveControl = null;
        }

        private void changePositiveNegative()
        {
            if (display.Text != "")
            {
                String symbol;
                if (decimal.Parse(display.Text) > 0)
                {
                    symbol = "-";
                    display.Text = decimal.Parse(symbol + Math.Abs((decimal.Parse(display.Text)))).ToString();
                }
                else
                {
                    symbol = "+";
                    display.Text = decimal.Parse(symbol + Math.Abs((decimal.Parse(display.Text)))).ToString();
                }
            }
        }
        //EVENTS
        //----------------------------------------------------------------
        private void btn_number0_Click(object sender, EventArgs e)
        {
            addTxt("0");
        }

        private void btn_number1_Click(object sender, EventArgs e)
        {
            addTxt("1");
        }

        private void btn_number2_Click(object sender, EventArgs e)
        {
            addTxt("2");
        }

        private void btn_number3_Click(object sender, EventArgs e)
        {
            addTxt("3");
        }

        private void btn_number4_Click(object sender, EventArgs e)
        {
            addTxt("4");
        }

        private void btn_number5_Click(object sender, EventArgs e)
        {
            addTxt("5");
        }

        private void btn_number6_Click(object sender, EventArgs e)
        {
            addTxt("6");
        }

        private void btn_number7_Click(object sender, EventArgs e)
        {
            addTxt("7");
        }

        private void btn_number8_Click(object sender, EventArgs e)
        {
            addTxt("8");
        }

        private void btn_number9_Click(object sender, EventArgs e)
        {
            //otra manera de añadir el número, en este caso es añadiendo el texto del botón ya que en este caso por ejemplo es 9
            //display.Text = display.Text + btn_number9.Text; 
            addTxt("9");
        }
        private void reset()
        {
            //Limpia la pantalla
            display.Clear();
            suma = false;
            resta = false;
            division = false;
            multiplicacion = false;
            total1 = 0;
            total2 = 0;
            ActiveControl = null;
        }
        private void btn_clearDisplay_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            multiplicar();
        }

        private void btn_split_Click(object sender, EventArgs e)
        {
            dividir();
        }
        
        private void btn_add_Click(object sender, EventArgs e)
        {
            sumar();
        }
        
        private void btn_equals_Click(object sender, EventArgs e)
        {
            igualar();
        }

        private void btn_substract_Click(object sender, EventArgs e) //resta
        {
            restar();
        }
       
        private void btn_deleteDigit_Click(object sender, EventArgs e)
        {
            eliminarDigito();
        }

        private void btn_decimal_Click(object sender, EventArgs e)
        {
            addDecimal();
        }

        private void addDecimal()
        {
            if (!display.Text.Contains(",") && !display.Text.Contains("."))
            {
                if (display.Text.Length == 0)
                {
                    display.Text = "0";
                }
                display.Text = display.Text + ",";
            }
            ActiveControl = null;
        }

        private void FormMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                addTxt(e.KeyChar.ToString());
            }
            else if (e.KeyChar.ToString() == "." || e.KeyChar.ToString() == ",")
            {
                addDecimal();
            }
            else if (e.KeyChar.ToString() == "+")
            {
                sumar();
            }
            else if (e.KeyChar.ToString() == "-")
            {
                restar();
            }
            else if (e.KeyChar.ToString() == "*")
            {
                multiplicar();
            }
            else if (e.KeyChar.ToString() == "/")
            {
                dividir();
            }
            else if (e.KeyChar == '\r')
            {
                igualar();
                ActiveControl = null;
            }
            else if (e.KeyChar == '\b')
            {
                eliminarDigito();
                ActiveControl = null;
            }
            else if (e.KeyChar == 'c' || e.KeyChar == 'C')
            {
                eliminarDigito();
                ActiveControl = null;
            }
            else if (e.KeyChar == 's')
            {
                changePositiveNegative();
                ActiveControl = null;
            }

        }

        private void btn_changeSymbol_Click(object sender, EventArgs e)
        {
            changePositiveNegative();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form3 = new Form3();
            Form3.Show();
        }

        private void comandosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();
            Form2.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //https://cie-wc.edu/C_Calculator_10-25.pdf
        //http://lluisvera.com/c-opciones-de-los-dialogos-de-mensaje-messagebox/
    }
}
