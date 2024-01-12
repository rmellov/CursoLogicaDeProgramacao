using System.Globalization;

namespace Uri_1014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distanciaTotalPercorrida;
            double totalCombustivelGasto, consumoMedio;

            distanciaTotalPercorrida = int.Parse(Console.ReadLine());
            totalCombustivelGasto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            consumoMedio = distanciaTotalPercorrida / (double) totalCombustivelGasto;

            Console.WriteLine("{0} km/l", consumoMedio.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}