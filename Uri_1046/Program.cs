﻿namespace Uri_1046
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, duracao;
            string[] vet = Console.ReadLine().Split(' ');

            horaInicial = int.Parse(vet[0]);
            horaFinal = int.Parse(vet[1]);

            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU {0} HORA(S)", duracao);
        }
    }
}
