using System.Globalization;

namespace Uri_1017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempoGasto, velocidadeMedia;
            double kml, litrosNecessario;

            kml = 12.0;
            tempoGasto = int.Parse(Console.ReadLine());
            velocidadeMedia = int.Parse(Console.ReadLine());
            litrosNecessario = tempoGasto * velocidadeMedia / kml;

            Console.WriteLine(litrosNecessario.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
