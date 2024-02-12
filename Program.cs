using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            byte a = 20;
            sbyte b = 50;
            ushort c = 65535;

            float d = 5.45f;
            double e = 5.45d;

            bool test = true;

            string text = "Test";

            Console.WriteLine("Prom a je " + a);
            Console.ReadKey();*/

            /*
            Console.WriteLine("Enter first number ");
            byte number1 = byte.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number ");
            byte number2 = byte.Parse(Console.ReadLine());

            int sum = number1 + number2;

            Console.WriteLine("Sum is " + sum);
            Console.ReadKey();*/

            /*
            Console.WriteLine("Enter time");
            int time = byte.Parse(Console.ReadLine());

            double distance_m = time * 344;
            double distance_km = distance_m / 1000;

            Console.WriteLine("Distance light is " + distance_km + "km");

            Console.ReadKey();*/

            Console.WriteLine("Enter firts number ");
            int a = byte.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number ");
            int b = byte.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(a + " is greater than " + b);
            }

            else if (a == b)
            {
                Console.WriteLine(b + " is identical than " + a);
            }

            else
            { 
                Console.WriteLine(b + " is greater than " + a);
            }

            Console.ReadKey();
        }
    }
}