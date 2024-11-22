using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArbol
{
    internal class Nodo
    {
        public int valor;
        public Nodo izq;
        public Nodo der;

        public Nodo(int Valor)
        {
            valor = Valor;
            izq = null;
            der = null;
        }
    }
}
