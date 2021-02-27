using System;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double x1;
            double x2;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            double d;
            d = b*b-4*a*c;
            if (d<0)
            {
                Console.WriteLine("Дескриминант меньше 0, решений нет");
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                if (d == 0)
                {
                    Console.WriteLine($"x = {x1}");
                }
                else
                {
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine($"x1 = {x1}, x2 = {x2}");
                }
            }
        }
    }
}
