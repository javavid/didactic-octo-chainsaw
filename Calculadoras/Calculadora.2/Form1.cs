namespace Calculadora._2
{
    public partial class Form1 : Form
    {
        Operaciones operaciones1 = new Operaciones();
        double valor1, valor2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botonsuma_Click(object sender, EventArgs e)
        {
            if (textvalor1.Text != String.Empty)
                valor1 = Convert.ToDouble(textvalor1.Text);

            if (textvalor2.Text != String.Empty)
                valor2 = Convert.ToDouble(textvalor2.Text);

            textresultado.Text = operaciones1.Suma(valor1, valor2).ToString();
        }

        private void botonresta_Click(object sender, EventArgs e)
        {
            if (textvalor1.Text != String.Empty)
                valor1 = Convert.ToDouble(textvalor1.Text);

            if (textvalor2.Text != String.Empty)
                valor2 = Convert.ToDouble(textvalor2.Text);

            textresultado.Text = operaciones1.Resta(valor1, valor2).ToString();
        }

        private void botonmultiplicar_Click(object sender, EventArgs e)
        {
            if (textvalor1.Text != String.Empty)
                valor1 = Convert.ToDouble(textvalor1.Text);

            if (textvalor2.Text != String.Empty)
                valor2 = Convert.ToDouble(textvalor2.Text);

            textresultado.Text = operaciones1.Multiplicar(valor1, valor2).ToString();
        }

        private void botondividir_Click(object sender, EventArgs e)
        {
            if (textvalor1.Text != String.Empty)
                valor1 = Convert.ToDouble(textvalor1.Text);

            if (textvalor2.Text != String.Empty)
                valor2 = Convert.ToDouble(textvalor2.Text);

            textresultado.Text = operaciones1.Dividir(valor1, valor2).ToString();
        }
    }
}