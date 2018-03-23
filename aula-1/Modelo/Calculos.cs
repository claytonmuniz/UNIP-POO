using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_1.Modelo
{
    public class Calculos: absprop
    {
         public Calculos(Double n1, Double n2, String op): base(n1, n2, op)
        {
            Calcular();
        }

        public void Calcular()
        {
            if (this.op.Equals("+"))
            this.resposta = (this.n1 + this.n2).ToString();
            if (this.op.Equals("-"))
            this.resposta = (this.n1 - this.n2).ToString();
            if (this.op.Equals("*"))
            this.resposta = (this.n1 * this.n2).ToString();
            if (this.op.Equals("/"))
            this.resposta = (this.n1 / this.n2).ToString();
        }

    }
}
