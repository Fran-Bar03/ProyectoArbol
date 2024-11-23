using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArbol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           Arbol Miarbol = new Arbol();
            Miarbol.Insertar(15);
            Miarbol.Insertar(8);
            Miarbol.Insertar(5);
            Miarbol.Insertar(12);
            Miarbol.Insertar(23);
            Miarbol.Insertar(17);
            Miarbol.Insertar(25);




            // Calcular el promedio de los recorridos
            Miarbol.RecorridoPorNiveles();


            Console.ReadLine();


        }
    }
}
