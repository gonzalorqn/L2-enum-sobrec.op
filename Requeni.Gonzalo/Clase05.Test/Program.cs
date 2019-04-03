using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase05.Entidades;

namespace Clase05.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta obj1 = new Tinta();
            Tinta obj2 = new Tinta(ConsoleColor.Red);
            Tinta obj3 = new Tinta(ConsoleColor.Green,ETipoTinta.China);
            Tinta obj4 = new Tinta();

            Pluma p1 = new Pluma("BIC", 20, obj1);

            if(obj1 == obj4)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son distintos");
            }

            Console.WriteLine(Tinta.Mostrar(obj1));
            Console.WriteLine(Tinta.Mostrar(obj2));
            Console.WriteLine(Tinta.Mostrar(obj3));

            Console.ReadLine();
        }
    }
}
