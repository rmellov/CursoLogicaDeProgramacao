namespace Uri_1134
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0, gasolina = 0, diesel = 0;
            int escolha = int.Parse(Console.ReadLine());            

            while (escolha != 4)
            {
                if (escolha == 1)
                {
                    alcool += 1;
                }
                else if (escolha == 2)
                {
                    gasolina += 1;
                }
                else if (escolha == 3)
                {
                    diesel += 1;
                }

                escolha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: {0}", alcool);
            Console.WriteLine("Gasolina: {0}", gasolina);
            Console.WriteLine("Diesel: {0}", diesel);
        }
    }
}