using System.Globalization;

namespace Uri_1011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, volume, pi;

            pi = 3.14159;
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            volume = 4 / 3.0 * pi * Math.Pow(raio, 3.0);

            Console.WriteLine("VOLUME = {0}", volume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}