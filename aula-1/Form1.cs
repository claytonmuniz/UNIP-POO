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
            Controle controle = new Controle(txbPrimeiroNumero.Text, txbSegundoNumero.Text, "+");
            if (controle.mensagem.Equals(""))
            {
                lblResultado.Text = controle.Resposta;
            }
            else 
            {MessageBox.Show(controle.mensagem


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle(
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            
        }
    }
}
