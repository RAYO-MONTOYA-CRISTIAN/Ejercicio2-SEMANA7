using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i= 3; i <= 1000; i+= 3) 
            {
                int contador = i / 3;
                Console.WriteLine($"Divisor de Omar Orlandini {contador}: {i}");

            }
        }
    }
}
