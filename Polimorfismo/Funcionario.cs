using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Funcionario
    {
        //Propriedades do Funcionário
        public string Nome = "";

        public string Cargo = "";

        public double Salario = 0;

        //Exemplo de Sobrecarga
        //Método Construtor 1
        public Funcionario()
        {
            Nome = "Desconhecido";
            Cargo = "Desconhecido";
            Salario = 0;
        }
        //Método Construtor 2
        public Funcionario(string n)
        {
            Nome = n;
            Cargo = "Desconhecido";
            Salario = 0;
        }

        //Método Construtor 3
        public Funcionario(string n, string c)
        {
            Nome = n;
            Cargo = c;
        }

        //Método Construtor 4
        public Funcionario(string n, string c, double s)
        {
            Nome = n;
            Cargo = c;
            Salario = s;
        }

        //Exemplo de Sobrescrita na classe mãe

        //Função (Exibe todas as caracteristicas do funcionario)
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome} | Cargo: {Cargo} | Salario: R${Salario}");
        }

    }
}
    
