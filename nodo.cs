using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArbol
{
    public class nodo
    {
        public int Valor;
        public nodo izq;
        public nodo der;
        public nodo(int valor)
        {
            Valor = valor;
            izq = null;
            der = null;
        }
    }
}
