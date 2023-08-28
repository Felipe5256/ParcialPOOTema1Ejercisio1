using PrismaRectangularRecto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar Largo (A)");
            int largo =int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar Altura (B)");
            int altura = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar Ancho (C)");
            int ancho=int.Parse(Console.ReadLine());

            PrismaRectangular pr = new PrismaRectangular(largo, ancho, largo);

            Console.WriteLine(pr.MostrarDatos());
            Console.ReadLine();

        }
        
    }
}
