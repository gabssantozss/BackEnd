  using SobescritaESobrecarga;
Console.WriteLine($"");
Console.WriteLine($""); 

Funcionario f1 = new Funcionario("Carlos", "Limpador", 3000);
f1.ExibirDados();
Console.WriteLine($"");
Console.WriteLine($"");
Gerente g1 = new Gerente("Vendas");
g1.Nome = "Adriano";
g1.Salario = 7000;
g1.ExibirDados();
Console.WriteLine($"");
Console.WriteLine($"");
