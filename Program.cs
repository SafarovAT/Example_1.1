using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1._1
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Введите R1");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Введите R2");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Введите R3");
            float d = float.Parse(Console.ReadLine());
            double R;
            R = 1 / ((1 / a) + (1 / b) + (1 / d));
            Console.WriteLine("Полное сопротивление: {0}", 1 / ((1 / a) + (1 / b) + (1 / d)));
            Console.ReadKey();

        }
    }
}
