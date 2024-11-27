using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArbol
{
    public class cola
    {
        private nodoLCP Inicio;
        private int count;
        private int MAX;

        public cola(int num)
        {
            MAX = num;
        }

        private bool Underflow()
        {
            if (Inicio == null)
            {
                return true;
            }
            return false;
        }
        private bool Overflow()
        {
            if (count == MAX)
            {
                return true;
            }
            return false;
        }
        public void Print()
        {
            if (!Underflow())
            {
                nodoLCP actual = Inicio;
                while (actual != null)
                {
                    Console.Write($" {actual.Valor}==>");
                    actual = actual.Sig;
                }
                Console.WriteLine("---||");
            }
            else
            {
                Console.WriteLine("La lista esta vacia");
            }
        }

        public int Count()
        {
            return count;
        }

        public bool Insert(int num)
        {
            nodoLCP nuevo = new nodoLCP(num);

            if (Inicio == null)
            {
                Inicio = nuevo;
                count++;
                return true;
            }
            else if (!Overflow())
            {
                nodoLCP actual = Inicio;

                while (actual.Sig != null)
                {
                    actual = actual.Sig;
                }
                count++;
                actual.Sig = nuevo;

                return true;
            }
            return false;
        }
        public bool Extract()
        {
            if (!Underflow())
            {
                Inicio = Inicio.Sig;
                count--;
                return true;
            }
            return false;
        }
    }
}
