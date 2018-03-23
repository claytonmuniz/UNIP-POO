using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_1.Modelo
{
    public class Controle: absprop
    {
        public Controle(String num1, String num2, String op): base(num1, num2, op)
        {
            this.Executar();
        }

        public void Executar()
        {
            this.mensagem = "";
            Validacao validacao = new Validacao(this.num1,this.num2,this.op );
            validacao.Validar();
            if (validacao.mensagem.Equals(""))
            {
                Calculos calculos = new Calculos(validacao.n1, validacao.n2, this.op);
                this.resposta = calculos.resposta;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }


        }
    }
}
