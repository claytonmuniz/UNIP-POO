using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Double n1 = 0.0, n2 = 0.0, resultado = 0.0; //criando variaveis
            n1 = Convert.ToDouble(txbPrimeiroNumero.Text);
            n2 = Convert.ToDouble(txbSegundoNumero.Text);
            resultado = n1 + n2;
            lblResultado.Text = resultado.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double n1 = 0.0, n2 = 0.0, resultado = 0.0; //criando variaveis
            n1 = Convert.ToDouble(txbPrimeiroNumero.Text);
            n2 = Convert.ToDouble(txbSegundoNumero.Text);
            resultado = n1 - n2;
            lblResultado.Text = resultado.ToString();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            Double n1 = 0.0, n2 = 0.0, resultado = 0.0; //criando variaveis
            n1 = Convert.ToDouble(txbPrimeiroNumero.Text);
            n2 = Convert.ToDouble(txbSegundoNumero.Text);
            resultado = n1 / n2;
            lblResultado.Text = resultado.ToString();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            Double n1 = 0.0, n2 = 0.0, resultado = 0.0; //criando variaveis
            n1 = Convert.ToDouble(txbPrimeiroNumero.Text);
            n2 = Convert.ToDouble(txbSegundoNumero.Text);
            resultado = n1 * n2;
            lblResultado.Text = resultado.ToString();
            txbPrimeiroNumero.Text = "";
            txbSegundoNumero.Text = "";
        }
    }
}
