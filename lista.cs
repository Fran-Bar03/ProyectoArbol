using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArbol
{
    public class lista
    {
        nodoLCP inicio;
        public lista()
        {
            inicio = null;
        }

        public void Add(int num)
        {
            nodoLCP nuevo = new nodoLCP(num);

            if (inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                nodoLCP act = inicio;
                while (act.Sig != null)
                {
                    act = act.Sig;
                }
                act.Sig = nuevo;
            }
        }

        public void Print()
        {
            if (inicio == null)
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                nodoLCP act = inicio;
                while (act != null)
                {
                    Console.Write($" {act.Valor}=>");
                    act = act.Sig;
                }
                Console.Write("--||");
            }
            Console.ReadKey();
        }

        public int Find(int pos)
        {
            if (inicio == null || pos < 0)
            {
                return -1;
            }
            else if (pos == 0)
            {

                return inicio.Valor;
            }
            else
            {
                nodoLCP act = inicio;
                int contador = 0;
                do
                {
                    contador++;
                    act = act.Sig;
                    if (act == null)
                    {
                        return -1;
                    }
                }
                while (pos != contador);
                int value = act.Valor;
                return value;
            }
        }
        public int Count()
        {
            int contador = 0;
            if (inicio == null)
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                nodoLCP act = inicio;
                do
                {
                    contador++;
                    act = act.Sig;
                }
                while (act != null);
            }
            return contador;
        }

        public int FindValue(int num)
        {
            nodoLCP act = inicio;

            if (inicio == null)
            {
                return -1;
            }
            else if (num == act.Valor)
            {
                return 0;
            }
            else
            {
                int contador = 0;
                do
                {
                    contador++;
                    act = act.Sig;
                    if (act == null)
                    {
                        return -1;
                    }
                }
                while (num != act.Valor);
                int value = contador;
                return value;
            }
        }

        public bool Delete(int pos)
        {

            if (inicio == null)
            {
                return false;
            }
            else if (pos == 0)
            {
                nodoLCP anterior = inicio;
                nodoLCP actual = inicio;
                inicio = null;
                inicio = actual.Sig;
                return true;
            }
            else
            {
                nodoLCP act = inicio;
                nodoLCP anterior = act;
                int contador = 0;
                do
                {
                    if (contador == (pos - 1))
                    {
                        anterior = act;
                    }
                    contador++;
                    act = act.Sig;
                    if (act == null)
                    {
                        return false;
                    }
                }
                while (pos != contador);
                anterior.Sig = act.Sig;
                return true;
            }
        }

        public bool Modificacion(int pos, int num)
        {
            nodoLCP act = inicio;

            if (inicio == null)
            {
                return false;
            }
            else if (pos == 0)
            {
                act.Valor = num;
                return true;
            }
            else
            {
                int contador = 0;
                do
                {
                    contador++;
                    act = act.Sig;
                    if (act == null)
                    {
                        return false;
                    }
                }
                while (pos != contador);
                act.Valor = num;
                return true;
            }
        }
    }
}
