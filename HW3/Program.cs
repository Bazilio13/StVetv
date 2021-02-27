using System;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    if (b > c)
                    {
                        Console.WriteLine($"{c} {b} {a}");
                    }
                    else
                    {
                        Console.WriteLine($"{b} {c} {a}");
                    }
                }
                else
                {
                    Console.WriteLine($"{b} {a} {c}");
                }
            }
            else
            {
                if (b > c)
                {
                    if (a > c)
                    {
                        Console.WriteLine($"{c} {a} {b}");
                    }
                    else
                    {
                        Console.WriteLine($"{a} {c} {b}");
                    }
                }
                else
                {
                    Console.WriteLine($"{a} {b} {c}");
                }
            }
        }
    }
}
