namespace Uri_1020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idadeEmDias, anos, meses, dias, resto;

            idadeEmDias = int.Parse(Console.ReadLine());

            anos = idadeEmDias / 365;
            resto = idadeEmDias % 365;

            meses = resto / 30;
            dias = resto % 30;

            Console.WriteLine("{0} ano(s)", anos);
            Console.WriteLine("{0} mes(es)", meses);
            Console.WriteLine("{0} dia(s)", dias);
        }
    }
}
