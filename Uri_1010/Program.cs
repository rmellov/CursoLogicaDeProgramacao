using System.Globalization;

namespace Uri_1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigoPeca1, codigoPeca2, numeroPeca1, numeroPeca2; 
            double valorUnitarioPeca1, valorUnitarioPeca2, valorTotal;
            string[] vet = Console.ReadLine().Split(' ');

            codigoPeca1 = int.Parse(vet[0]);
            numeroPeca1 = int.Parse(vet[1]);
            valorUnitarioPeca1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');

            codigoPeca2 = int.Parse(vet[0]);
            numeroPeca2 = int.Parse(vet[1]);
            valorUnitarioPeca2 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            valorTotal = numeroPeca1 * valorUnitarioPeca1 + numeroPeca2 * valorUnitarioPeca2;

            Console.WriteLine("VALOR A PAGAR: R$ {0}", valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}