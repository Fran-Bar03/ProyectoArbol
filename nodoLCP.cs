using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArbol
{
    public class nodoLCP
    {
        private int valor;
        private nodoLCP sig;
        public nodoLCP(int valor)
        {
            this.Valor = valor;
            this.Sig = null;
        }

        public int Valor { get => valor; set => valor = value; }
        internal nodoLCP Sig { get => sig; set => sig = value; }
    }
}

