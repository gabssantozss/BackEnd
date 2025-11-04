string[] nomes = new string[4];
int[] idades = new int[4];
int TotalAlunos = 0;
int opcao = -1;
// nomes[0] = "Maria";

// idades [0] = 20;

// nomes[1] = "Matheus";

// idades[1] = 16;

// nomes[2] = "ELoysa";

// idades[2] = 17;

// nomes[3] = "Felipe";

// idades[3] = 17;

// nomes[4] = "Jose";
// idades[4] = 50;
do
{
  Console.WriteLine($"1) Cadastrar alunos");
  Console.WriteLine($"2) Listar alunos");
  Console.WriteLine($"0) Sair");
  Console.Write($"Digite sua opcao:");
  opcao = int.Parse(Console.ReadLine());

  switch (opcao)
  {
    case 0:
      Console.WriteLine($"Encerrando...");
      Console.WriteLine($"Pressione <Enter> para encerrar...");
      Console.ReadLine();
      break;

    case 1:
      CadastrarAluno();
      break;

    case 2:
      ListarAlunos();
      break;

    default:
      Console.WriteLine($"Opcao invalida, pressione <Enter> pra continuar...");
      Console.ReadLine();
      break;

  }
} while (opcao != 0);

void ListarAlunos()
{
  Console.WriteLine();
  Console.WriteLine($"Resultado: ");

  for (int i = 0; i < nomes.Length; i++)
  {
    Console.WriteLine($"   Nome : {nomes[1]}");
    Console.WriteLine($"   Idade : {idades[i]}anos");
    Console.WriteLine();

  }
}



void CadastrarAluno()

{
  if (TotalAlunos >= 4)
  {
    Console.WriteLine($"Nao limite de ocupacao atingida");
    return;
  }

  Console.WriteLine($"Digite o nome do aluno");
  string n = Console.ReadLine();
  Console.WriteLine($"Digite a idade de {n}");
  int i = int.Parse(Console.ReadLine());

  nomes[TotalAlunos] = n;
  idades[TotalAlunos] = i;
  TotalAlunos++;

  Console.WriteLine($"Aluno Cadastrado com sucesso");
  Console.WriteLine($"Ha {TotalAlunos} aluno(s) cadastrado(s) no sistema!");
  Console.WriteLine($"Pressione <Enter> para continuar");
  Console.ReadLine();
}