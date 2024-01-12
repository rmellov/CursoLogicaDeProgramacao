using System.Globalization;

namespace Uri_1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;            
            double salarioFixo, vendasMensal, comissao, totalReceber;

            nome = Console.ReadLine();
            comissao = 0.15;
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendasMensal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalReceber = comissao * vendasMensal + salarioFixo;

            Console.WriteLine("TOTAL = R$ {0}", totalReceber.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}