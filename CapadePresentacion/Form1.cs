namespace CapadePresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declarar variables
            int num1, num2, resultado;

            //Definir las variables con lo que se añade en el cuadro de texto
            num1 = Convert.ToInt16(textBox1.Text);
            num2 = Convert.ToInt16(textBox2.Text);

            //Realizar la multiplicacion
            resultado = num1 * num2;

            //Mostrar el resultado en el area correspondiente
            textBox3.Text = resultado.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}