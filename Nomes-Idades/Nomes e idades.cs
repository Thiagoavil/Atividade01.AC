using System;

namespace Nomes_Idades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            int idade = 0;
            int diasviv = 0;
                
            Console.WriteLine("Calculo de dias vividos");
            Console.WriteLine("Qual seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Qual sua idade?");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            diasviv = idade * 365;
            Console.WriteLine("Você " + nome + " viveu um total de " + diasviv + " dias");

        }
    }
}
