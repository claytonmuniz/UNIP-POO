using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_1.Modelo
{
    public class Controle
    {
        public String num1;
        public String num2;
        public String op;
        public String resposta;
        public String mensagem;

        public void Executar()
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.num1 = this.num1;
            validacao.num2 = this.num2;
            validacao.op = this.op;
            validacao.Validar();
            if (validacao.mensagem.Equals(""))
            {
                Calculos calculos = new Calculos();
                calculos.n1 = validacao.n1;
                calculos.n2 = validacao.n2;
                calculos.op = this.op;
                calculos.Calcular();
                this.resposta = calculos.resposta;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }


        }
    }
}
