using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_1.Modelo
{
    public class Controle
    {
        #region Atributos
        private String num1;
        private String num2;
        private String resposta;
        private String op;
        public String mensagem;
        #endregion
        #region Construtores
        public Controle()
        {
        }
        public Controle(String num1, String num2, String op)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.op = op;
            this.calcular();
        }
        #endregion

        #region Metodos
        public void calcular()
        {
            this.mensagem = "";
            Double n1 = 0.0, n2 = 0.0, resultado = 0.0; //criando variaveis
            try
            {
                n1 = Convert.ToDouble(this.num1);
                n2 = Convert.ToDouble(this.num2);
                if (this.op.Equals("+"))
                    resultado = n1 + n2;
                if (this.op.Equals("-"))
                    resultado = n1 - n2;
                if (this.op.Equals("*"))
                    resultado = n1 * n2;
                this.resposta = resultado.ToString("0.##");
                if (this.op.Equals("/"))
                    if (n2 == 0)
                    {
                        this.resposta = "Nâo é possivel dividir por 0";
                        num1 = "";
                        num2 = "";
                    }
                    else
                    {
                        resultado = n1 / n2;
                        this.resposta = resultado.ToString("0.##");
                    }

            }
            catch (FormatException )
            {
                this.resposta = "Digite um número valido doente";
                num1 = "";
                num2 = "";
            }

        #endregion


        }
        #region Propriedades
        public String Resposta
        {
            get { return resposta; }
            set { resposta = value; }
        }
        } private String num1;

            public String Num1 
            {
                get { return num1; }
                set { num1 = value; }
            }

            private String num2;

            public String Num2
            {
                get { return num2; }
                set { num2 = value; }
            }

            private String resposta;

        private String op;

        public String Op
        {
            get { return op; }
            set { op = value; }
        }
        #endregion
    }
    }
