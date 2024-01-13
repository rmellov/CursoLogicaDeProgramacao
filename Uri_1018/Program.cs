namespace Uri_1018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor, nota100, nota50, nota20, nota10, nota5, nota2, nota1, resto;

            valor = int.Parse(Console.ReadLine());

            nota100 = valor / 100;
            resto = valor % 100;

            nota50 = resto / 50;
            resto %= 50;

            nota20 = resto / 20;
            resto %= 20;

            nota10 = resto / 10;
            resto %= 10;

            nota5 = resto / 5;
            resto %= 5;

            nota2 = resto / 2;
            resto %= 2;

            nota1 = resto / 1;

            Console.WriteLine(valor);
            Console.WriteLine("{0} nota(s) de R$ 100,00", nota100);
            Console.WriteLine("{0} nota(s) de R$ 50,00", nota50);
            Console.WriteLine("{0} nota(s) de R$ 20,00", nota20);
            Console.WriteLine("{0} nota(s) de R$ 10,00", nota10);
            Console.WriteLine("{0} nota(s) de R$ 5,00", nota5);
            Console.WriteLine("{0} nota(s) de R$ 2,00", nota2);
            Console.WriteLine("{0} nota(s) de R$ 1,00", nota1);
        }
    }
}