using System;

namespace Atividades.AC
{
    internal class Imobiliaria
    {
        static void Main(string[] args)
        {

            double largura = 0;
            double profundidade = 0;
            double area = 0;



           
                Console.WriteLine("Imobiliaria Móbilis");
                Console.WriteLine("/-------------------/");
                Console.WriteLine("Calculo de Area do terreno");
                Console.WriteLine("digite a largura: ");
                largura = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a pronfundidade: ");
                profundidade = Convert.ToDouble(Console.ReadLine());

                area = largura * profundidade;
                Console.WriteLine("A area é de: " + area);
                Console.WriteLine("");









        }
    }
}
