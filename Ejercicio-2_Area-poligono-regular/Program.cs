using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_Area_poligono_regular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la apotema: ");
            double apotema = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el perímetro: ");
            double perimeter = double.Parse(Console.ReadLine());
            Console.WriteLine("El área es: " + calculateArea(apotema, perimeter));
        }

        public static double calculateArea (double a, double p)
        {
            double result = 0.0;
            result = a * p / 2;
            return result;
        }
    }
}
