using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArbol
{
    public class pila
    {
        private int MAX;
        private int cantidad = 0;
        private nodoLCP Inicio;
        public pila(int max)
        {
            MAX = max;
            Inicio = null;
        }

        public bool Empty()
        {
            if (Inicio == null)
                return true;
            else
                return false;
        }

        public bool Full()
        {
            if (cantidad == MAX)
                return true;
            else
                return false;
        }

        public void PrintStack()
        {
            if (Empty())
            {
                Console.WriteLine("La pila esta vacia");
            }
            else
            {
                int i = 0;
                nodoLCP actual = Inicio;
                int[] valores = new int[cantidad];
                do
                {
                    valores[i] = actual.Valor;
                    actual = actual.Sig;
                    i++;
                }
                while (actual != null);

                for (int j = (cantidad - 1); j > -1; j--)
                {
                    Console.WriteLine($"|-{valores[j]}-|");
                }
            }
        }
        public bool Push(int num)
        {
            //regresa true si la insercion es exitosa
            //regresa false si la pila esta llena y no inserto
            nodoLCP nuevo = new nodoLCP(num);
            if (Full())
            {
                return false;
            }
            else if (Inicio == null)
            {
                Inicio = nuevo;
                cantidad++;
                return true;
            }
            else
            {
                nodoLCP actual = Inicio;

                while (actual.Sig != null)
                {
                    actual = actual.Sig;
                }
                actual.Sig = nuevo;
                cantidad++;
                return true;
            }
        }
        public int Pop()
        {
            int eliminado = -1;
            //regresa eliminado si la eliminacion es exitosa
            //regresa -1 si la pila esta vacia y no elimino
            if (Empty())
            {
                return -1;
            }
            else if (Inicio.Sig == null)
            {
                eliminado = Inicio.Valor;
                Inicio = null;
                cantidad--;
                return eliminado;
            }
            else
            {
                nodoLCP actual = Inicio;
                while (actual.Sig.Sig != null)
                {
                    actual = actual.Sig;
                }
                eliminado = actual.Sig.Valor;
                actual.Sig = null;
                cantidad--;
                return eliminado;
            }

        }
    }
}
