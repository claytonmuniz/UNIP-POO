using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_1.Modelo
{
    public class Validacao
    {
        public String num1;
        public String num2;
        public Double n1;
        public Double n2;
        public String mensagem;
        public String op;

        public void Validar()
        {
            this.mensagem = "";
            try
            {
                this.n1 = Convert.ToDouble(this.num1);
                
            
            }
            catch (FormatException e)
            {
                
                this.mensagem = "Erro de conversão no primeiro campo \n";
            }

            try
            {
                this.n2 = Convert.ToDouble(this.num2);


            }
            catch (FormatException e)
            {

                this.mensagem += "Erro de conversão no segundo campo \n";
            }
            if (this.num2.Equals("0") && this.op.Equals("/"))
            {
                this.mensagem += "Divisão por zero";
            }
        }

    }

}
