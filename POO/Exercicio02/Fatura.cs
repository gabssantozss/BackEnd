using System.Diagnostics.Contracts;
using Exercicio02;
public class Fatura : IImprimivel
    {

        public string Devedor = "";
        public string Credor = "";
        public float Valor = 0;
        public int DiasDeAtraso = 0;
        public float Juros = 0.10f;

        public Fatura(string dev, string cred, float valFat, int qtdAtraso )
        {
            Devedor = dev;
            Credor = cred;
            DiasDeAtraso = qtdAtraso;
            Valor = valFat;
        }

        public void Imprimir()
        {
            System.Console.WriteLine($"Credor:  {Devedor}...");
            System.Console.WriteLine($"Devedor:  {Devedor}...");
            System.Console.WriteLine($"Juros:  {Valor * DiasDeAtraso}...");
            System.Console.WriteLine($"Total com juros:  {Valor}...");
            System.Console.WriteLine($"Dias De Atraso:  {DiasDeAtraso} dia(s)");
        }

        public void CalcularValorDivida()
        {
            if(DiasDeAtraso > 0)
            {
                Valor = Valor + DiasDeAtraso * Juros;
            }
            if(DiasDeAtraso >= 5)
            {
                System.Console.WriteLine($"Dívida encaminhada para o SERASA");
            }
        }
    }

