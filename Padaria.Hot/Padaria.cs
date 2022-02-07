using System;

namespace Padaria.Hot
{
    internal class Padaria
    {
        static void Main(string[] args)
        {
            const double paozinho = 0.12;
            const double broa = 1.50;
            int paesvend = 0;
            int broasvend = 0;
            double lucropao = 0;
            double lucrobroa = 0;
            double lucrodia = 0;
            double poupanca = 0;


            Console.WriteLine("Padaria HOT");
            Console.Write("Pães Vendidos: ");
            paesvend =Convert.ToInt32(Console.ReadLine());
            Console.Write("Broas Vendidas: ");
            broasvend = Convert.ToInt32(Console.ReadLine());

            lucropao = paesvend * paozinho;
            lucrobroa = broasvend * broa;
            lucrodia = lucrobroa + lucropao;


            Console.WriteLine("Lucro do dia é= " + lucrodia);
            poupanca = lucrodia * 0.1;
            Console.WriteLine("Guarde R$" + Math.Round(poupanca,2) + " na poupança");
            


        }
    }
}
