﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_1.Modelo
{
    public abstract class absprop
    {
        public absprop (String num1, String num2, String op)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.op = op;
        }
        public absprop(Double n1, Double n2, String op)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.op = op;
        }

        public Double n1;
        public Double n2;
        public String op;
        public String resposta;
        public String num1;
        public String num2;
        public String mensagem;             
    }
}
