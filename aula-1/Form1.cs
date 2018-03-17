using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using aula_1.Modelo;
namespace aula_1
{
    public partial class frmPrincipal : Form
    {
        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Executar(String op)
        {
            Modelo.Controle controle = new Modelo.Controle();
            controle.num1 = txbPrimeiroNumero.Text;
            controle.num2 = txbSegundoNumero.Text;
            controle.op = op;
            controle.Executar();
            if (controle.mensagem.Equals(""))
            {
                lblResultado.Text = controle.resposta;

            }
            else
            {
                MessageBox.Show(controle.mensagem);
                txbPrimeiroNumero.Clear();
                txbSegundoNumero.Clear();
                lblResultado.Text = "Resultado";
                txbPrimeiroNumero.Focus();
            }

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
            Executar("+");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Executar("-");
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            Executar("/");
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            Executar("*");
        }
    }
}
