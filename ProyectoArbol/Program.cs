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
            Miarbol.Insertar(23);
            Miarbol.Insertar(2);
            Miarbol.Insertar(25);
            Miarbol.Insertar(12);
            Miarbol.Recorrido(Miarbol.raiz);
            Console.ReadLine();


        }
    }
}
