using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_1.Modelo
{
    public class Controle
    {
        public String calcular(String num1, String num2, String op)
        {
            Double n1 = 0.0, n2 = 0.0, resultado = 0.0; //criando variaveis
            String resposta = "";
            try
            {
                n1 = Convert.ToDouble(num1);
                n2 = Convert.ToDouble(num2);
                if (op.Equals("+"))
                    resultado = n1 + n2;
                if (op.Equals("-"))
                    resultado = n1 - n2;
                if (op.Equals("*"))
                    resultado = n1 * n2;
                resposta = resultado.ToString("0.##");
                if (op.Equals("/"))
                    if (n2 == 0)
                    {
                        resposta = "Nâo é possivel dividir por 0";
                        num1 = "";
                        num2 = "";
                    }
                    else
                    {
                        resultado = n1 / n2;
                        resposta = resultado.ToString("0.##");
                    }

            }
            catch (FormatException e)
            {
                resposta = "Digite um número valido doente";
                num1 = "";
                num2 = "";
            }
            return resposta;



        }
    }
}
