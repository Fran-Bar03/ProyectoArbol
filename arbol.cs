using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArbol
{
    public class arbol
    {
        public nodo raiz;
        private nodo obs;
        private int contador;
        private int Longitud;
        private int longitudGuardada;
        private int longitudMayor;
        private int ValorGuardado;
        private int contadorRaiz;

        public void Insertar(int Valor) 
        {
            nodo nuevo;
            nodo psave;
            bool Found = false;
            psave = obs;
            Found = FindKey(Valor);
            if(Found) 
            {
                Console.WriteLine("El nodo ya existe");
                obs = psave;
            }
            else 
            {
                nuevo = new nodo(Valor);
                if (raiz == null)
                {
                    raiz = nuevo;
                    obs = nuevo;
                    contador++;
                }
                else 
                {
                    if(Valor < obs.Valor)
                    {
                        obs.izq = nuevo;
                    }
                    else 
                    {
                        obs.der = nuevo;
                    }
                    obs = nuevo;
                    contador++;
                }
            }
        }

        private bool FindKey(int Valor) 
        {
            bool Found = false;
            nodo q = raiz;
            while(!Found && q != null) 
            {
                if(Valor == q.Valor) 
                {
                    obs = q;
                    Found = true;
                }
                else if (Valor != q.Valor)
                {
                    if(Valor < q.Valor) 
                    {
                        if (q.izq == null)
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

        public void Recorrido(nodo q)
        {
            if (q != null) 
            {
                Console.Write($"{q.Valor}, ");
                Recorrido(q.izq);
                Console.Write($"{q.Valor}, ");
                Recorrido(q.der);
                Console.Write($"{q.Valor}, ");
            }
        }

        public void LRP()
        {
            // Usamos una cola para recorrer por niveles
            Queue<nodo> Cola = new Queue<nodo>();
            Cola.Enqueue(raiz);

            int sumaRecorridos = 0;
            double countRecorridos = 0;

            // Recorremos todos los nodos por niveles
            while (Cola.Count > 0)
            {
                nodo nodoActual = Cola.Dequeue();
                nodo temp = raiz;
                string recorrido = $"{temp.Valor}";

                // Encontrar la ruta desde la raíz hasta el nodo actual
                while (temp != nodoActual)
                {
                    if (nodoActual.Valor < temp.Valor)
                    {
                        temp = temp.izq;
                        recorrido = recorrido + $",{temp.Valor}";
                    }
                    else
                    {
                        temp = temp.der;
                        recorrido = recorrido + $",{temp.Valor}";
                    }
                }

                // Imprimir el recorrido y la cantidad de nodos
                int cantidadnodos = recorrido.Split(',').Length;
                Console.WriteLine($"{recorrido} = {cantidadnodos}");  // impresion del recorrido

                sumaRecorridos = sumaRecorridos + cantidadnodos;
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
        public int Tamano() 
        {
            return contador;
        }

        public void Altura(nodo q)
        {
            int contadorPorCiclo = 0;

            if (q != null)
            {

                if (ValorGuardado != q.Valor)
                {
                    Longitud++;
                }
               
                ValorGuardado = q.Valor;

                if(raiz.Valor == q.Valor) 
                {
                    contadorRaiz++;
                }

                contadorPorCiclo++;

                Altura(q.izq);


                if (ValorGuardado != q.Valor && contadorPorCiclo < 0)
                {
                    Longitud++;
                }

                if (raiz.Valor == q.Valor)
                {
                    contadorRaiz++;
                    Longitud = 1;
                }

                contadorPorCiclo++;

                if(contadorPorCiclo == 2 && ValorGuardado != q.Valor && Longitud != 1)
                {
                    Longitud--;
                }
                 
                Altura(q.der);

                if (raiz.Valor == q.Valor)
                {
                    contadorRaiz++;
                }

                if (ValorGuardado != q.Valor && contadorPorCiclo < 0)
                {
                    Longitud++;
                }
                else if (ValorGuardado == q.Valor) 
                {
                    longitudGuardada = Longitud;
                }

            }

            if (longitudGuardada > longitudMayor)
            {
                longitudMayor = longitudGuardada;
                longitudGuardada = 0;
            }

            if (contadorRaiz == 3) 
            {
                Console.WriteLine(longitudMayor);
                contadorRaiz = 0;
                longitudMayor = 0;
                longitudGuardada = 0;
                ValorGuardado = 0;
                Longitud = 0;
            }
        }
    }
}

