using System.Runtime.InteropServices;
using Exercicio02;

/*Relatorio r1 = new Relatorio();
r1.Imprimir();
Contrato c1 = new Contrato();
c1.Imprimir();
Fatura f1 = new Fatura();
f1.Imprimir();*/

/*List<Fatura>  ListaDeFaturas = new List<Fatura>();
List<Relatorio>  ListaDeRelatorio = new List<Relatorio>();
List<Contrato>  ListadeContrato = new List<Contrato>();
Fatura fatZe = new Fatura();
fatZe.Dono = "Ze felipe";
Fatura fatVi = new Fatura();
fatVi.Dono = "Virginia";
Fatura fatFlor = new Fatura();
fatFlor.Dono = "Maria flor";
Fatura fatMali = new Fatura();
fatMali.Dono = "Maria Alice";
Fatura fatVini = new Fatura();
fatVini.Dono = "Vinicius jr";
Fatura fatAna = new Fatura();
fatAna.Dono = "Ana Castelo";

ListaDeFaturas.Add (fatZe);
ListaDeFaturas.Add (fatVi);
ListaDeFaturas.Add (fatFlor);
ListaDeFaturas.Add (fatMali);
ListaDeFaturas.Add (fatVini);
ListaDeFaturas.Add (fatAna);


foreach (var item in ListaDeFaturas)
{
    item.Imprimir();
}

Relatorio relEloysa = new Relatorio();
Relatorio relAmylee = new Relatorio();
relEloysa.Nome = "Eloysa Marques";
relAmylee.Nome = "Amylee";
ListaDeRelatorio.Add(relEloysa);
ListaDeRelatorio.Add(relAmylee);

foreach (var item in ListaDeRelatorio)
{
    item.Imprimir();
}

Contrato contEloysa = new Contrato();
Contrato contAmylee = new Contrato();
contAmylee.Nome = "Amylee";
contEloysa.Nome = "Eloysa Marques ";

ListadeContrato.Add(contAmylee);
ListadeContrato.Add(contEloysa);
foreach (var item in ListadeContrato)
{
    item.Imprimir();
}*/
List<IImprimivel> documentos = new List<IImprimivel>();

// Fatura fatEdu = new Fatura("Eduardo", "Izabel Dark Lab", 50, 1);

// fatEdu.Imprimir();

// Criar um menu da seguinte forma:


List<Fatura> listaFatura = new List<Fatura>();
List<Relatorio> listaRelatorio = new List<Relatorio>();
List<Contrato> listaContrato = new List<Contrato>();

int opcao;
do
{
    Console.WriteLine($"Menu de Opções");
    Console.WriteLine(@"
1) Cadastrar Fatura
2) Cadastrar Relatório
3) Cadastrar Contrato
4) Listar Faturas
5) Listar Relatórios
6) Listar Contratos
0) Sair
Escolher a opção: ");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            CadastrarFatura();
            break;
        case 2:
            CadastrarRelatorio();
            break;
        case 3:
            CadastrarContrato();
            break;
        case 4:
            ListarFatura();
            break;
        case 5:
            ListarRelatorio();
            break;
        case 6:
            ListarContrato();
            break;
        case 0:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

    if (opcao != 0)
    {
        Console.WriteLine("Apertar ENTER para continuar...");
        Console.ReadLine();
        Console.Clear();
    }

} while (opcao != 0);



void CadastrarFatura()
{
    Console.WriteLine("Digite o nome do devedor:");
    string dev = Console.ReadLine();

    Console.WriteLine("Digite o nome do credor:");
    string cred = Console.ReadLine();

    Console.WriteLine("Digite o valor da fatura:");
    float valor = float.Parse(Console.ReadLine());

    Console.WriteLine("Quantos dias a fatura está atrasada:");
    int diasAtraso = int.Parse(Console.ReadLine());

    Fatura f = new Fatura(dev, cred, valor, diasAtraso);

    listaFatura.Add(f);
    Console.WriteLine("Fatura cadastrada com sucesso!");
}

void CadastrarContrato()
{
    Console.WriteLine("Digite o nome do contratante:");
    string contratante = Console.ReadLine();

    Console.WriteLine("Digite o nome do contratado:");
    string contratado = Console.ReadLine();

    Console.WriteLine("Digite as cláusulas:");
    string txtClausulas = Console.ReadLine();

    Contrato c = new Contrato(contratante, contratado, txtClausulas);

    listaContrato.Add(c);
    Console.WriteLine("Contrato cadastrado com sucesso!");
}

void CadastrarRelatorio()
{
    Console.WriteLine("Digite o nome do responsável pelo relatório:");
    string responsavel = Console.ReadLine();

    Console.WriteLine("Digite o texto do relatório:");
    string txt = Console.ReadLine();

    Relatorio r = new Relatorio(responsavel, txt);

    listaRelatorio.Add(r);
    Console.WriteLine("Relatório cadastrado com sucesso!");
}

void ListarRelatorio()
{
    foreach (var item in listaRelatorio)
    {
        item.Imprimir();
    }
}

void ListarContrato()
{
    foreach (var item in listaContrato)
    {
        item.Imprimir();
    }
}

void ListarFatura()
{
    foreach (var item in listaFatura)
    {
        item.Imprimir();
    }
}
