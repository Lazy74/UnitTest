﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a*x^2+b*x+c=0");
            Console.WriteLine("Введите a");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите b");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите c");
            double c = Convert.ToDouble(Console.ReadLine());
            
            Class1 p = new Class1(a,b,c);
            double D = 0;
            D = p.fn();
            Console.WriteLine("{0}", D);

            if (D > 0)
            {
                double x1 = (-b - Math.Sqrt(D)) / 2 * a;
                double x2 = (-b + Math.Sqrt(D)) / 2 * a;

                Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
            }
            if (D == 0)
            {
                double x = -b / (2 * a);

                Console.WriteLine("x = {0}", x);
            }
            if (D < 0)
            {
                Console.WriteLine("Нет значений!");
            }

            Console.ReadKey();
        }
    }
}
