using System;

namespace Lenda
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada, R, L, J;
            string[] vetor;

            while ((entrada = Console.ReadLine()) != null)
            {
                vetor = entrada.Split('+');
                R = vetor[0];
                vetor = vetor[1].Split('=');
                L = vetor[0];
                J = vetor[1];

                if (J == "J" || J == "j")
                {
                    Console.WriteLine(int.Parse(R) + int.Parse(L));
                }
                else if (R == "R" || R == "r")
                {
                    Console.WriteLine(int.Parse(J) - int.Parse(L));
                }
                else if (L == "L" || L == "l")
                {
                    Console.WriteLine(int.Parse(J) - int.Parse(R));
                }
                else
                {
                    Console.WriteLine("Dados Inseridos Invalidos");
                }
            }
        }
    }
}
