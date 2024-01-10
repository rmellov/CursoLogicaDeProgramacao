using System.Globalization;

namespace Uri_1005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, pesoA, pesoB, media;

            pesoA = 3.5;
            pesoB = 7.5;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            media = (a * pesoA + b * pesoB) / (pesoA + pesoB);

            Console.WriteLine("MEDIA = {0}", media.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}
