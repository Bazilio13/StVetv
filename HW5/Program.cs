using System;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int num1;
            int num2;
            string str = "";
            a = Convert.ToInt32(Console.ReadLine());
            num1 = a / 10;
            num2 = a % 10;
            if (a<20)
            {
                switch (a)
                {
                    case 10:
                        str = "десять";
                        break;
                    case 11:
                        str = "одиннадцать";
                        break;
                    case 12:
                        str = "двенадцать";
                        break;
                    case 13:
                        str = "тринадцать";
                        break;
                    case 14:
                        str = "четырнадцать";
                        break;
                    case 15:
                        str = "пятнадцать";
                        break;
                    case 16:
                        str = "шестнадцать";
                        break;
                    case 17:
                        str = "семнадцать";
                        break;
                    case 18:
                        str = "восемнадцать";
                        break;
                    case 19:
                        str = "девятнадцать";
                        break;
                }
                Console.WriteLine(str);
            }
            else
            {
                switch(num1)
                {
                    case 2:
                        str = "двадцать";
                        break;
                    case 3:
                        str = "тридцать";
                        break;
                    case 4:
                        str = "сорок";
                        break;
                    case 5:
                        str = "пятьдесят";
                        break;
                    case 6:
                        str = "шестьдесят";
                        break;
                    case 7:
                        str = "семьдесят";
                        break;
                    case 8:
                        str = "восемьдесят";
                        break;
                    case 9:
                        str = "девяносто";
                        break;
                }
                switch(num2)
                {
                    case 0:
                        str += "";
                        break;
                    case 1:
                        str += " один";
                        break;
                    case 2:
                        str += " два";
                        break;
                    case 3:
                        str += " три";
                        break;
                    case 4:
                        str += " четыре";
                        break;
                    case 5:
                        str += " пять";
                        break;
                    case 6:
                        str += " шесть";
                        break;
                    case 7:
                        str += " семь";
                        break;
                    case 8:
                        str += " восемь";
                        break;
                    case 9:
                        str += " девять";
                        break;

                }
                Console.WriteLine(str);
            }
        }
    }
}
