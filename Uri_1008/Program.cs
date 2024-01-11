using System.Globalization;

namespace Uri_1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroFuncionario, horasTrabalhadas;
            double valorPorHora, salarioFuncionario;

            numeroFuncionario = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioFuncionario = horasTrabalhadas * valorPorHora;

            Console.WriteLine("NUMBER = {0}", numeroFuncionario);
            Console.WriteLine("SALARY = U$ {0}", salarioFuncionario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}