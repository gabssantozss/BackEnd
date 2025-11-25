using System.Globalization;

namespace ClassesEstaticas
{
    public class CalculosMatematicos
    {
       public static float Somar (float a, float b)
        {
          return a + b;
        }
        public static float Subtrair (float a, float b)
        {
            return a - b;
        }
        public static float Multiplicar (float a, float b)
        {
            return a * b;
        }

                public static float Dividir (float a, float b)
        {
            if(b == 0)
            {
                System.Console.WriteLine($"Divisao invalia");
                
            }
            return a / b;
        }
    }
}