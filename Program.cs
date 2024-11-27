namespace ProyectoArbol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menus miMenu = new menus();
            int opcion = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("MENU PROYECTO FINAL");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("1.- Listas");
                Console.WriteLine("2.- Pilas");
                Console.WriteLine("3.- Colas");
                Console.WriteLine("4.- Árboles");
                Console.WriteLine("5.- Salir");
                Console.WriteLine("---------------------------------------");
                Console.Write("Seleccionar Opción => ");

                try
                {
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            miMenu.menuLista();
                            break;
                        case 2:
                            miMenu.menuPila();
                            break;
                        case 3:
                            miMenu.menuCola();
                            break;
                        case 4:
                            miMenu.menuArbol();
                            break;
                        case 5:
                            Console.WriteLine("Saliendo del programa...");
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

                if (opcion != 5)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }

            } while (opcion != 5);
        }
    }
}
