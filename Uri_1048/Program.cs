using System.Globalization;

namespace Uri_1048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, percentual, reajuste, novoSalario;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 400.0)
            {
                percentual = 15.0;
            }
            else if (salario <= 800.0)
            {
                percentual = 12.0;                
            }
            else if (salario <= 1200.0)
            {
                percentual = 10.0;
            }
            else if (salario <= 2000.0)
            {
                percentual = 7.0;
            }
            else
            {
                percentual = 4.0;
            }

            reajuste = salario * percentual / 100.0;
            novoSalario = salario + reajuste;

            Console.WriteLine("Novo salario: {0}", novoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: {0}", reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: {0} %", percentual);
        }
    }
}