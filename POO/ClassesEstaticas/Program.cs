// See https://aka.ms/new-console-template for more information
using ClassesEstaticas;

Console.WriteLine("Bem-vindo ao programa!!");
System.Console.WriteLine();
System.Console.WriteLine($"Digite um numero:");
float a =float.Parse(Console.ReadLine());
System.Console.WriteLine($"Digite outro numero:");
float b = float.Parse(Console.ReadLine());
if (a == b)
{
    System.Console.WriteLine($"Os dois numeros sao iguais");
}
else
{
    System.Console.WriteLine($"o numero maior e:  {Math.Max(a, b)} e o menor e: {Math.Min(a, b)}");
}
/*float r = CalculosMatematicos.Somar(a, b);
Console.WriteLine($"Soma: {r}");

r = CalculosMatematicos.Subtrair(a, b);
System.Console.WriteLine($"subtracao: {r}");

r = CalculosMatematicos.Multiplicar(a, b);
System.Console.WriteLine($"multiplicacao: {r}");

r = CalculosMatematicos.Dividir(a, b);
System.Console.WriteLine($"Divisao: {r}");*/

//Solicitar ao usuario 2 numeros reais e informar qual e o maior e qual e o menor dos numeros. Para isso voce deve utilizar a class math, utulitsria do c#
