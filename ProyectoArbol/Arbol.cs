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



        public void RecorridoPorNiveles()
        {
            // Usamos una cola para recorrer por niveles
            Queue<Nodo> Cola = new Queue<Nodo>();
            Cola.Enqueue(raiz);

            int sumaRecorridos = 0;
            double countRecorridos = 0;

            // Recorremos todos los nodos por niveles
            while (Cola.Count > 0)
            {
                Nodo nodoActual = Cola.Dequeue();
                Nodo temp = raiz;
                string recorrido = $"{temp.valor}";

                // Encontrar la ruta desde la raíz hasta el nodo actual
                while (temp != nodoActual)
                {
                    if (nodoActual.valor < temp.valor)
                    {
                        temp = temp.izq;
                        recorrido = recorrido + $",{temp.valor}";
                    }
                    else
                    {
                        temp = temp.der;
                        recorrido = recorrido + $",{temp.valor}";
                    }
                }

                // Imprimir el recorrido y la cantidad de nodos
                int cantidadNodos = recorrido.Split(',').Length;
                Console.WriteLine($"{recorrido} = {cantidadNodos}");

                sumaRecorridos = sumaRecorridos + cantidadNodos;
                countRecorridos++;

                // Agregar nodos hijos a la cola
                if (nodoActual.izq != null) Cola.Enqueue(nodoActual.izq);
                if (nodoActual.der != null) Cola.Enqueue(nodoActual.der);
            }

            // Cálculo del promedio
            double promedio = sumaRecorridos / countRecorridos;
            Console.WriteLine($"\nSuma total de recorridos: {sumaRecorridos}");
            Console.WriteLine($"Cantidad de nodos: {countRecorridos}");
            Console.WriteLine($"LRP {sumaRecorridos}/{countRecorridos}= {promedio:F3}");
        }
    }
}






