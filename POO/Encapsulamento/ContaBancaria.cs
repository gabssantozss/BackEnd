namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;

        public ContaBancaria()
        {
            Saldo = 0;
        }

        public ContaBancaria(float saldoInicial)
        {
            if (saldoInicial >= 0)
            {
                Saldo = saldoInicial;
                return;
            }
          System.Console.WriteLine($"valor para deposito invalido");
        }

        

        public void Depositar (float Valor)
        {
            if (Valor >= 0)
            {
                Saldo = Valor;
                return;
            }
          System.Console.WriteLine($"valor para deposito invalido");
        }

        public float GetSaldo()
        {
            return Saldo;
        }

        public void saque(float valor)
        {
            if (valor > Saldo)
            {
                System.Console.WriteLine($"saque efetuado com sucesso");
                return;
            }
            System.Console.WriteLine($"valor para saque invalido");
        }
    }
}