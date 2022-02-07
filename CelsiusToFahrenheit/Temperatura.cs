using System;

namespace CelsiusToFahrenheit
{
    internal class Temperatura
    {
        static void Main(string[] args)
        {
            double c = 0;
            double f = 0;


            Console.WriteLine("Conversor °C/°F");
            Console.WriteLine("");
            Console.WriteLine("Digite a temperatura em °C:");
            c = Convert.ToDouble(Console.ReadLine());
            f = c * 1.8 + 32;
            Console.WriteLine("A temperatura é " + Math.Round(f,2) + " °F");

        }
    }
}
