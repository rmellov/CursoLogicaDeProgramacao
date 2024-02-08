﻿using System.Globalization;

namespace Uri_1117
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, media;
            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while(n1 < 0.0 || n1 > 10.0)
            {
                Console.WriteLine("nota invalida");
                n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (n2 < 0.0 || n2 > 10.0)
            {
                Console.WriteLine("nota invalida");
                n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            media = (n1 + n2) / 2.0;
            Console.WriteLine("media = {0}", media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}