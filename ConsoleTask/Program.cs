using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            double x, y, z, r;

            Console.Write("Введіть значення x = ");
            if (double.TryParse(Console.ReadLine(), out x)) ;
            else
            {
                Console.WriteLine("Error! Недопустиме значення x");
                return;
            }

            Console.Write("Введіть значення y = ");
            if (double.TryParse(Console.ReadLine(), out y)) ;
            else
            {
                Console.WriteLine("Error! Недопустиме значення y");
                return;
            }

            Console.Write("Введіть значення z = ");
            if (double.TryParse(Console.ReadLine(), out z)) ;
            else
            {
                Console.WriteLine("Error! Недопустиме значення z");
                return;
            }

            r = (2.0 * Math.Cos(x * x) - 0.5) / (0.5 + Math.Sin(Math.Pow(y, (2 - z)))) + (z * z) / (7 - z / 3.0);
            Console.WriteLine($"Результат r = {r.ToString("F2")}");
        }
    }
}
