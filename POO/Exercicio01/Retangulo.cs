using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio1
{
    public class Retangulo : IForma
    {
        public void CalcularArea()
        {
            double h;
            double l;
            double a;
            Console.WriteLine($"Digite a altura do retângulo:");
            h = double.Parse(Console.ReadLine());
            Console.WriteLine($"Digite a largura do retângulo:");
            l = double.Parse(Console.ReadLine());
            a = l * h;
            Console.WriteLine($"A área do retângulo é de {a}");
        }
    }
}