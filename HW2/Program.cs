using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            if (y > 0)
            {
                if (x > 0)
                {
                    Console.WriteLine("I");
                }
                else
                {
                    Console.WriteLine("II");
                }
            }
            else
            {
                if (x > 0)
                {
                    Console.WriteLine("IV");
                }
                else
                {
                    Console.WriteLine("III");
                }
            }
        }
    }
}
