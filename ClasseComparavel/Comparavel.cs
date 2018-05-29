using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseComparavel
{
    public class Comparavel
    {
        private int valor;

        public int Valor { get; }

        public Comparavel(int Valor)
        {
            valor = Valor;
        }

        public bool MaiorOuIgual(int ValorPassado)
        {
            return this.valor >= ValorPassado;
        }

        public bool MenorOuIgual(int ValorPassado)
        {
            return this.valor <= ValorPassado;
        }

        public bool DiferenteDe(int ValorPassado)
        {
            return this.valor != ValorPassado;
        }
    }
}
