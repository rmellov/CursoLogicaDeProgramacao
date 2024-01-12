using System.Globalization;

namespace Uri_1012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, pi, triangulo, circulo, trapezio, quadrado, retangulo;
            string[] vet;

            pi = 3.14159;
            vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            triangulo = a * c / 2.0;
            circulo = pi * Math.Pow(c, 2.0);
            trapezio = (a + b) * c / 2.0;
            quadrado = Math.Pow(b, 2.0);
            retangulo = a * b;

            Console.WriteLine("TRIANGULO: {0}", triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: {0}", circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: {0}", trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: {0}", quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: {0}", retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}