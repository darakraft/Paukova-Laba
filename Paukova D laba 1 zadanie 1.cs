using System;

namespace ConsoleApp1
{
    class Program
    { 
        static void Main(string[] args)
        { double x; double y; double z;
            Console.WriteLine("Ведите х");
          x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ведите y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ведите z");
            z = Convert.ToDouble(Console.ReadLine());
            
        double c = MyFunction(x, y, z);
            Console.WriteLine(c);

         
        }

        static double MyFunction(double x, double y, double z)
        { double c;
            c = Math.Pow(2, y * x) + Math.Pow(3, x * y) - (y * (Math.Atan2(z, z) - Math.PI / 6)) / Math.Abs(x) + (1 / Math.Pow(y, 2) + 1);
            return c;

        }
    }
}
