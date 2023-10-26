namespace practica7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v1, far1;
            v1 = double.Parse(valor.Text);
            far1 = v1 * (9.0 / 5.0) + 32;
            Resultado.Text = far1.ToString("0.##");
            label2.Text = ("Fahrenheit");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double v2, cen1;
            v2 = double.Parse(valor.Text);
            cen1 = (v2 - 32) * (5.0 / 9.0);
            Resultado.Text = cen1.ToString("0.##");
            label2.Text = ("Centigrados");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            valor.Text = "";
            Resultado.Text = "";
        }
    }
}