using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseComparavel
{
    public class Comparavel
    {
        private int valorEncapsulado;

        public Comparavel()
        {
            this.valorEncapsulado = 10;
        }

        public bool MaiorOuIgual(int valor)
        {
            return this.valorEncapsulado >= valor;
        }

        public bool MenorOuIgual(int valor)
        {
            return this.valorEncapsulado <= valor;
        }

        public bool DiferenteDe(int valor)
        {
            return this.valorEncapsulado != valor;
        }
    }
}
