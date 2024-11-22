using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArbol
{
    internal class Arbol
    {
        public Nodo raiz;
        private Nodo obs;

        public void Insertar(int v)
        {
            Nodo nuevo, psave;
            Boolean Found = false;
            psave = obs;
            Found = Findkey(v);

            if (Found)
            {
                Console.WriteLine("El nodo ya existe");
                obs = psave;
            }

            else
            {
                nuevo = new Nodo(v);

                if (raiz == null)
                {
                    raiz = nuevo;
                    obs = nuevo;
                }

                else
                {
                    if(v < obs.valor)
                        obs.izq = nuevo;
                        else 
                        obs.der= nuevo;
                        obs = nuevo;
                    
                }
    
            }
        }


        private bool Findkey(int v)
        {
            Boolean Found = false;
            Nodo q;
            q = raiz;

            while(!Found  &&  q != null)
            {

                if (v == q.valor)
                {
                    obs = q;
                    Found = true;
                }

                else
                {
                    if (v < q.valor)
                    {
                        if(q.izq == null)
                            obs = q;
                        q = q.izq;
                    }
                    else
                    {
                        if (q.der == null)
                            obs = q;
                        q = q.der;
                    }
                }
            }

            return Found;
        }


       public void Recorrido(Nodo q)
        {
            if(q != null)
            {
                Console.Write($"{q.valor}");
                Recorrido(q.izq);
                Console.Write($"{q.valor}");
                Recorrido(q.der);
                Console.Write($"{q.valor}");


            }
        }
    }
}
