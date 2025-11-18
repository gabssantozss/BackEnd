
namespace Exercicio1
{
    public class Circulo : IForma
    {
        public void CalcularArea()
        {
            double r;
            double a;
            Console.WriteLine($"Digite o raio do círculo:");
            r = double.Parse(Console.ReadLine());
            a = r * r * Math.PI;
            Console.WriteLine($"A área do círculo é de {a}");
        }
    }
}
    
