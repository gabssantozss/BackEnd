using System.Reflection;
using System.Runtime.CompilerServices;
using ExerciciosMetodosConstrutor;

// Carro c1 = new Carro("Toyota", "Corolla", 2022);
// c1.ExibirDados();
// Console.WriteLine();

// Aluno a1 = new Aluno();
// Aluno a2 = new Aluno("gabriella", 10.00);
// System.Console.WriteLine(@$"Aluno 1:
// Nome: {a1.Nome}
// Nota: {a1.Nota}");
// Console.WriteLine();
// System.Console.WriteLine(@$"Aluno 2:
// Nome: {a2.Nome}
// Nota; {a2.Nota}");


MediaAluno a1 = new MediaAluno(6, 7, 2);

a1.Nome = "Lucas";
a1.Media();

MediaAluno a2 = new MediaAluno();
a2.Nome = "Samuel";
a2.Media();