using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ExerciciosMetodosConstrutor
{
    public class Carro
    {
        public string Modelo;

        public string Marca;

        public int Ano;


        public Carro(string mo, string ma, int a)
        {
            Modelo = mo;
            Marca = ma;
            Ano = a;
        }

        public void ExibirDados()
        {
            System.Console.WriteLine($"Carro: {Marca} {Modelo}, Ano  {Ano}");
        }

    }
}