using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Gerente
    {
        string Setor = "";

        public Gerente(string S)
        {
            Setor = S;
        }

        //Exemplo de Sobrescrita na classe filha
        //A função é a mesma da classe mãe, porém, ao invés de mostrar o cargo, ela mostra o setor
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome} | Setor: {Setor} | Salario: R${Salario}");
        }
    }
}
    
