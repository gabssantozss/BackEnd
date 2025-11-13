using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ExerciciosMetodosConstrutor
{
    public class MediaAluno
    {
        public string Nome;
        public double N1, N2, N3;

        // Construtor com parâmetros
        public MediaAluno(double n1, double n2, double n3)
        {
            N1 = n1;
            N2 = n2;
            N3 = n3;
        }

        // Construtor sem parâmetros (notas começam em 0)
        public MediaAluno()
        {
            N1 = N2 = N3 = 0;
        }

        public void Media()
        {
            double media = (N1 + N2 + N3) / 3;
            System.Console.WriteLine($"A média do(a) {Nome} foi: {media:F2}");
        }
    }
}
