using System.Globalization;

namespace Uri_1002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area, raio, n;

            n = 3.14159;
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = Math.Pow(raio, 2.0) * n;

            Console.WriteLine("A={0}", area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
