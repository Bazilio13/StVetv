using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                a += b;
            }
            else
            {
                if (a < b)
                {
                    a -= b;
                }
                else
                {
                    a *= b;
                }
            }
            Console.WriteLine(a);
        }
    }
}
