using System.Globalization;

namespace Uri_1006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, pesoA, pesoB, pesoC, media;

            pesoA = 2.0;
            pesoB = 3.0;
            pesoC = 5.0;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (a * pesoA + b * pesoB + c * pesoC) / (pesoA + pesoB + pesoC);

            Console.WriteLine("MEDIA = {0}", media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}