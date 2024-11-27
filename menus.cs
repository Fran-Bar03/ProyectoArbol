using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArbol
{
    public class menus
    {
        arbol miarbol = new arbol();
        lista Lista = new lista();
        static pila Pila = null;
        cola miCola = new cola(1);

        public void menuLista()
        {
            bool salir = true;
            do
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════╗");
                Console.WriteLine("║            MENU LISTAS           ║");
                Console.WriteLine("╠══════════════════════════════════╣");
                Console.WriteLine("║  1. Insertar nodos               ║");
                Console.WriteLine("║  2. Imprimir tamaño              ║");
                Console.WriteLine("║  3. Buscar nodo                  ║");
                Console.WriteLine("║  4. Borrar nodo                  ║");
                Console.WriteLine("║  5. Modificar nodo               ║");
                Console.WriteLine("║  6. Buscar valor                 ║");
                Console.WriteLine("║  7. Imprimir lista               ║");
                Console.WriteLine("║  8. Regresar                     ║");
                Console.WriteLine("╚══════════════════════════════════╝");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out int opcion))
                {
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    Console.ReadKey();
                    continue;
                }

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el número del nodo a insertar: ");
                        int numeroAnadido = Convert.ToInt32(Console.ReadLine());
                        Lista.Add(numeroAnadido);
                        Console.WriteLine("Nodo insertado con éxito.");
                        break;
                    case 2:
                        Console.WriteLine($"La cantidad de nodos es: {Lista.Count()}");
                        break;
                    case 3:
                        Console.Write("Ingrese la posición del nodo a buscar: ");
                        int posicion = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El valor es: " + Lista.Find(posicion));
                        break;
                    case 4:
                        Console.Write("Ingrese la posición del nodo a borrar: ");
                        int borrar = Convert.ToInt32(Console.ReadLine());
                        if (Lista.Delete(borrar))
                        {
                            Console.WriteLine("El nodo se ha eliminado con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("El nodo no se ha encontrado.");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Ingrese el nuevo valor del nodo y su posición:");
                        Console.Write("Posición: ");
                        int pos = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Valor: ");
                        int valor = Convert.ToInt32(Console.ReadLine());
                        if (Lista.Modificacion(pos, valor))
                        {
                            Console.WriteLine("Nodo actualizado con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("El nodo no se ha encontrado.");
                        }
                        break;
                    case 6:
                        Console.Write("Ingrese el valor para buscar su posición: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"El valor {num} está en la posición {Lista.FindValue(num)}.");
                        break;
                    case 7:
                        Console.WriteLine("Elementos en la lista:");
                        Lista.Print();
                        break;
                    case 8:
                        salir = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
                if (opcion != 8)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            } while (salir);
        }
        public void menuPila()
        {
            int max;
            bool salir = true;
            do
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════╗");
                Console.WriteLine("║             MENU PILA            ║");
                Console.WriteLine("╠══════════════════════════════════╣");
                Console.WriteLine("║  1. Asignar máximo               ║");
                Console.WriteLine("║  2. Push                         ║");
                Console.WriteLine("║  3. Pop                          ║");
                Console.WriteLine("║  4. Imprimir                     ║");
                Console.WriteLine("║  5. Regresar                     ║");
                Console.WriteLine("╚══════════════════════════════════╝");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out int opcion))
                {
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    Console.ReadKey();
                    continue;
                }

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.Write("Asigne la cantidad máxima a la pila: ");
                        max = Convert.ToInt32(Console.ReadLine());
                        Pila = new pila(max);
                        Console.WriteLine("Tamaño máximo asignado correctamente.");
                        break;
                    case 2:
                        if (Pila == null)
                        {
                            Console.WriteLine("Debe asignar un tamaño máximo a la pila primero.");
                            break;
                        }
                        Console.Write("Ingrese el número del nodo a insertar: ");
                        int numeroAnadido = Convert.ToInt32(Console.ReadLine());
                        if (Pila.Push(numeroAnadido))
                        {
                            Console.WriteLine("Elemento añadido con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("Error: La pila está llena.");
                        }
                        break;
                    case 3:
                        if (Pila == null)
                        {
                            Console.WriteLine("Debe asignar un tamaño máximo a la pila primero.");
                            break;
                        }
                        int valor = Pila.Pop();
                        if (valor != -1)
                        {
                            Console.WriteLine($"Se ha eliminado el valor: {valor}");
                        }
                        else
                        {
                            Console.WriteLine("Error: La pila está vacía.");
                        }
                        break;
                    case 4:
                        if (Pila == null)
                        {
                            Console.WriteLine("Debe asignar un tamaño máximo a la pila primero.");
                            break;
                        }
                        Pila.PrintStack();
                        break;
                    case 5:
                        salir = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
                if (opcion != 5)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            } while (salir);
        }
        public void menuCola()
        {
            int max;
            bool salir = true;
            do
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════╗");
                Console.WriteLine("║             MENU COLA            ║");
                Console.WriteLine("╠══════════════════════════════════╣");
                Console.WriteLine("║  1. Asignar máximo               ║");
                Console.WriteLine("║  2. Enqueue (Insertar)           ║");
                Console.WriteLine("║  3. Dequeue (Eliminar)           ║");
                Console.WriteLine("║  4. Imprimir                     ║");
                Console.WriteLine("║  5. Regresar                     ║");
                Console.WriteLine("╚══════════════════════════════════╝");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out int opcion))
                {
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    Console.ReadKey();
                    continue;
                }

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.Write("Asigne la cantidad máxima a la cola: ");
                        max = Convert.ToInt32(Console.ReadLine());
                        miCola = new cola(max);
                        Console.WriteLine("Tamaño máximo asignado correctamente.");
                        break;
                    case 2:
                        if (miCola == null)
                        {
                            Console.WriteLine("Debe asignar un tamaño máximo a la cola primero.");
                            break;
                        }
                        Console.Write("Ingrese el número del nodo a insertar: ");
                        int numeroAnadido = Convert.ToInt32(Console.ReadLine());
                        if (miCola.Insert(numeroAnadido))
                        {
                            Console.WriteLine("Elemento añadido con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("Error: La cola está llena.");
                        }
                        break;
                    case 3:
                        if (miCola == null)
                        {
                            Console.WriteLine("Debe asignar un tamaño máximo a la cola primero.");
                            break;
                        }
                        
                        if (miCola.Extract())
                        {
                            Console.WriteLine($"Elemento extraido");
                        }
                        else
                        {
                            Console.WriteLine("Error: La cola está vacía.");
                        }
                        break;
                    case 4:
                        if (miCola == null)
                        {
                            Console.WriteLine("Debe asignar un tamaño máximo a la cola primero.");
                            break;
                        }
                        miCola.Print();
                        break;
                    case 5:
                        salir = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
                if (opcion != 5)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            } while (salir);
        }
        public void menuArbol()
        {
            int opcion = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════╗");
                Console.WriteLine("║            MENÚ ÁRBOLES          ║");
                Console.WriteLine("╠══════════════════════════════════╣");
                Console.WriteLine("║ 1. Insertar nodo                 ║");
                Console.WriteLine("║ 2. Tamaño                        ║");
                Console.WriteLine("║ 3. Altura                        ║");
                Console.WriteLine("║ 4. LRP                           ║");
                Console.WriteLine("║ 5. Recorrido                     ║");
                Console.WriteLine("║ 6. Regresar                      ║");
                Console.WriteLine("╚══════════════════════════════════╝");
                Console.Write("Seleccionar Opción => ");

                try
                {
                    opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            try
                            {
                                Console.Write("Ingrese el valor del nodo: ");
                                int valor = int.Parse(Console.ReadLine());
                                miarbol.Insertar(valor);
                                Console.WriteLine("Nodo insertado correctamente.");
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Error: Ingrese un valor numérico válido.");
                            }
                            break;
                        case 2:
                            if (!(miarbol.raiz == null))
                            {
                                Console.WriteLine($"El tamaño del árbol es: {miarbol.Tamano()}");
                            }
                            else
                            {
                                Console.WriteLine("El arbol esta vacio");
                            }
                            break;
                        case 3:
                            if (!(miarbol.raiz == null))
                            {
                                miarbol.Altura(miarbol.raiz);
                            }
                            else
                            {
                                Console.WriteLine("El arbol esta vacio");
                            }
                            break;
                        case 4:
                            if(!(miarbol.raiz == null))
                            {
                                Console.WriteLine("Recorrido en LRP:");
                                miarbol.LRP();
                            }
                            else
                            {
                                Console.WriteLine("El arbol esta vacio");
                            }
                            break;
                        case 5:
                            Console.WriteLine("Recorrido del árbol:");
                            if (!(miarbol.raiz == null))
                            {
                                miarbol.Recorrido(miarbol.raiz);
                            }
                            else
                            {
                                Console.WriteLine("El arbol esta vacio");
                            }
                            break;
                        case 6:
                            Console.WriteLine("Regresando al menú principal...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Intente nuevamente.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Ingrese una opción numérica válida.");
                }

                if (opcion != 6)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 6);
        }
    }
}

