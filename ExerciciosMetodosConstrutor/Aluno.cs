using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMetodosConstrutor
{
    public class Aluno
    {
        public string Nome;
        public double Nota;


        public Aluno()

        {
            Nome = "Sem nome";
            Nota = 0.0;
        }
        public Aluno(string nome, double nota)
        {
            Nome = nome;
        Nota = nota;
        }


        public void ExibirDados()
    {
        Console.WriteLine($"Aluno: {Nome}, Nota: {Nota}");
    }

    }
    
}