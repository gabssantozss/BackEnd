using System.Runtime.Intrinsics.Arm;
using MetodoConstrutor;


/*Pessoa gabriella = new Pessoa("Eloysa", 17);

gabriella.Nome = "Gabriella Santos";
gabriella.Idade = 17;
System.Console.WriteLine(@$"O objeto pessoa que criei e o {gabriella.Nome} com a idade 
{gabriella.Idade}");
gabriella.Nome = "livia";

System.Console.WriteLine($"{gabriella.Nome}");

gabriella.ExibirDados();*/



Pessoa3SobreCargas PrimeiraPessoa = new Pessoa3SobreCargas();
System.Console.WriteLine(@$"Primeira Pessoa cadastrada:
Nome: {PrimeiraPessoa.Nome} 
Idade: {PrimeiraPessoa.Idade}"
);

Pessoa3SobreCargas SegundaPessoa = new Pessoa3SobreCargas("Matheus Lima");
System.Console.WriteLine(@$"Primeira Pessoa cadastrada:
Nome: {SegundaPessoa.Nome} 
Idade: {SegundaPessoa.Idade}");


Pessoa3SobreCargas TerceiraPessoa = new Pessoa3SobreCargas("Amy lee", 17);
System.Console.WriteLine(@$"Primeira Pessoa cadastrada:
Nome: {TerceiraPessoa.Nome} 
Idade: {TerceiraPessoa.Idade}");
System.Console.WriteLine($"Escreva seu nome abaixo.");
