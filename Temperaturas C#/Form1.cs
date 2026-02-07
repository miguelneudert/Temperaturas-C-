namespace Temperaturas_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            string seleccion = "";
            if (rbcelcius.Checked)
            {
                txtcelcius.Enabled = true;
                txtkelvin.Enabled = false;
                txtfahrenheit.Enabled = false;
                float celsius = float.Parse(txtcelcius.Text);
                float fahrenheit = (celsius * 9f / 5f) + 32;
                txtfahrenheit.Text = fahrenheit.ToString();
                float kelvin = celsius + 273;
                txtkelvin.Text = kelvin.ToString();
                //MessageBox.Show("Celsius", "Tenperatura seleccionda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rbkelvin.Checked)
            {
                txtkelvin.Enabled = true;
                txtcelcius.Enabled = false;
                txtfahrenheit.Enabled = false;
                float kelvin = float.Parse(txtkelvin.Text);
                float celsius = kelvin - 273;
                txtcelcius.Text = celsius.ToString();
                float fahrenheit = (celsius * 9f / 5f) + 32;
                txtfahrenheit.Text = fahrenheit.ToString();
                //MessageBox.Show("Kelvin", "Tenperatura seleccionda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rbFahrenheit.Checked)
            {
                txtfahrenheit.Enabled = true;
                txtcelcius.Enabled = false;
                txtkelvin.Enabled = false;
                float fahrenheit = float.Parse(txtfahrenheit.Text);
                float celsius = (fahrenheit - 32) + 5.0f / 9.0f;
                txtcelcius.Text = celsius.ToString();
                float kelvin = celsius + 273;
                txtkelvin.Text = kelvin.ToString();


                //MessageBox.Show("Fahrenheit", "Tenperatura seleccionda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

    }
}

