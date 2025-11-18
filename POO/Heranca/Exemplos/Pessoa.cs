namespace Exemplos
{
    public class Pessoa : Animal
    {
        public override void FazerSom()
        {
            System.Console.WriteLine($"ola, sou uma pessoa");
        }

        public override void Mover()
        {
            System.Console.WriteLine($"Ploc Ploc Ploc");
        }
    }
}