using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_1.Modelo
{
    public class Validacao: absprop 
    {
        
         public Validacao(String num1, String num2, String op): base(num1, num2, op)
        {
            Validar();
        }
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
