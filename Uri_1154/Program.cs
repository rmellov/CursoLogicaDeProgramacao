using System.Globalization;

namespace Uri_1154
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade, soma = 0, contador = 0;
            double media;

            idade = int.Parse(Console.ReadLine());

            while(idade > 0)
            {
                contador++;
                soma += idade;
                idade = int.Parse(Console.ReadLine());
            }

            media = (double) soma / contador;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}