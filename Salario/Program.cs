using System;

namespace Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = 0;
            double aumentos = 0;    
            double salariof = 0;
            
            Console.WriteLine("Calculo de aumento e desconto");
            Console.WriteLine("");
            Console.WriteLine("Digite seu salário");
            salario =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            aumentos = salario * 0.15 + salario ;
            salariof = aumentos - aumentos * 0.08;
            Console.WriteLine("Seu salário base é de: R$" + Math.Round(salario,2));
            Console.WriteLine("Seu salário com aumento é: R$" + Math.Round(aumentos,2));
            Console.WriteLine("Seu salário final é: R$" + Math.Round(salariof,2));



        }
    }
}
