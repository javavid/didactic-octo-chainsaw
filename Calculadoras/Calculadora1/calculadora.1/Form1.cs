using System.Diagnostics;
using System.Linq.Expressions;

namespace calculadora._1
{
    public partial class Form1 : Form
    {
        private double valor1;
        private double valor2;
        private double resultado;

        private int operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            textLCD.Text = textLCD.Text + "1";
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            textLCD.Text = textLCD.Text + "2";
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            textLCD.Text = textLCD.Text + "3";
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            textLCD.Text = textLCD.Text + "4";
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            textLCD.Text = textLCD.Text + "5";
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            textLCD.Text = textLCD.Text + "6";
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            textLCD.Text = textLCD.Text + "7";
        }

        private void boton8_Click(object sender, EventArgs e)
        {
            textLCD.Text = textLCD.Text + "8";
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            textLCD.Text = textLCD.Text + "9";
        }

        private void botonpunto_Click(object sender, EventArgs e)
        {
            textLCD.Text = textLCD.Text + ".";
        }

        private void boton0_Click(object sender, EventArgs e)
        {
            textLCD.Text = textLCD.Text + "0";
        }

        private void botonigual_Click(object sender, EventArgs e)
        {

            valor2 = Convert.ToDouble(textLCD.Text);

            switch (operacion)
            {
                case 1:
                    resultado = valor1 * valor2;
                    break;

                case 2:
                    resultado = valor1 / valor2;
                    break;

                case 3:
                    resultado = valor1 + valor2;
                    break;

                case 4:
                    resultado = valor1 - valor2;
                    break;
            }
            textLCD.Text = resultado.ToString();
        }


        private void botonM_Click(object sender, EventArgs e)
        {

            operacion = 1;
            valor1 = Convert.ToDouble(textLCD.Text);
            textLCD.Text = "";
        }

        private void botonD_Click(object sender, EventArgs e)
        {

            operacion = 2;
            valor1 = Convert.ToDouble(textLCD.Text);
            textLCD.Text = "";
        }

        private void botonS_Click(object sender, EventArgs e)
        {

            operacion = 3;
            valor1 = Convert.ToDouble(textLCD.Text);
            textLCD.Text = "";
        }

        private void botonR_Click(object sender, EventArgs e)
        {

            operacion = 4;
            valor1 = Convert.ToDouble(textLCD.Text);
            textLCD.Text = "";
        }

        private void botonlimpiar_Click(object sender, EventArgs e)
        {
            textLCD.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
    }
}