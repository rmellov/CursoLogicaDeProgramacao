using System.Globalization;

namespace Uri_1038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigoItem, quantidadeItem;
            double total = 0.0;
            string[] vet = Console.ReadLine().Split(' ');

            codigoItem = int.Parse(vet[0]);
            quantidadeItem = int.Parse(vet[1]);

            switch (codigoItem)
            {
                case 1: total = 4.0 * quantidadeItem;
                    break;
                case 2: total = 4.50 * quantidadeItem;
                    break;
                case 3: total = 5.0 * quantidadeItem;
                    break;
                case 4: total = 2.0 * quantidadeItem;
                    break;
                case 5: total = 1.50 * quantidadeItem;
                    break;
                default:
                    break;
            }

            Console.WriteLine("Total: R$ {0}", total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}