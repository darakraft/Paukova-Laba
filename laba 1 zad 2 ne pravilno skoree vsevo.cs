using System;

namespace pro
{
    class Program
    {
        static void Main(string[] args)
        {
            double x; double y, z, min, max;

            Console.WriteLine("Введите x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите z");
            z = Convert.ToDouble(Console.ReadLine());
            double fx = Math.Pow(Math.E, x);
            double n1 = fx + y;
            Console.WriteLine(n1);
            double n2 = y - z;
            Console.WriteLine(n2);


            if (n1 < n2)
            {
                Console.WriteLine(n1);
                Console.WriteLine(min=n1); //если вот это условие выполнилось
            }
             else if (n1 > n2)
            {
                Console.WriteLine(n2);
                Console.WriteLine(min=n2);// то вот это не должно выполнятся, а программа все равно выводит(((( и в знаменателе так же
                //

            }

            if (fx > y)
            {
                Console.WriteLine(y);
                Console.WriteLine(max = y);
            }
            else if ( fx < y)
            {
                Console.WriteLine(fx);
                Console.WriteLine(max=fx);


            }
            Console.WriteLine(min / max);

            


            








        }
    }
}
