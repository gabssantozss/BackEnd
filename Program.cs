﻿//Criar um menu da seguinte forma em loop que chame as funcoes
//1. Cadastrar cliente
//2. Depositar
//3. Sacar
//4. Transferir
//5. Listar CLiente
//0. Sair
//Por enquanto, as funcoes apenas devem exibir uma mensagem "Funcao em desenvolvimento".
// == LISTA DE CLIENTES ===
//0. Eduardo | Saldo: R$ 0,00
//1. Marcos | Saldo: R$ 0,00



string[] nomes = new string[3];
double[] saldos = new double[3];
int totalClientes = 0;

int opcao = -1;//opção inválida

do
{
    Console.Clear();
    Console.WriteLine($"=== SISTEMA BANCÁRIO SIMPLES ===");
    Console.WriteLine();

    Console.WriteLine($"1. Cadastrar Cliente");
    Console.WriteLine($"2. Depositar");
    Console.WriteLine($"3. Sacar");
    Console.WriteLine($"4. Transferir");
    Console.WriteLine($"5. Listar Clientes");
    Console.WriteLine($"0. Sair");
    Console.WriteLine($"\nEscolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    //chamar função
    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Saindo ...");
            Console.WriteLine($"Clique em <Enter para continuar>");
            Console.ReadLine();
            break;

        case 1:
            CadastratCliente();
            break;

        case 2:
            Depositar();
            
            Console.WriteLine($"Clique em <Enter para continuar>");
            Console.ReadLine();
            break;

        case 3:
            Sacar();
            Console.WriteLine($"Clique em <Enter para continuar>");
            Console.ReadLine();
            break;

        case 4:
            Console.WriteLine($"Função em Desenvolvimento");
            Console.WriteLine($"Clique em <Enter para continuar>");
            Console.ReadLine();
            break;

        case 5:
            ListarCliente();
            break;

        default:
            Console.WriteLine($"Opção inválida! Clique <Enter> para continur");
            Console.ReadLine();
            break;

    }//fim do switch
} while (opcao != 0);




void CadastratCliente()
{
    //verificar se tem espaço no array para cadastrar
    if (totalClientes >= 3)
    {//não pode mais cadastrar
        Console.WriteLine($"Limite de ocupação atingido");
        Console.WriteLine($"Pressione <Enter> para continuar ...");
        return;
    }

    //Cadastra o cliente com o saldo inicial zerado!
    Console.Write($"Nome do Cliente: ");
    nomes[totalClientes] = Console.ReadLine();//guarda o nome no array
    saldos[totalClientes] = 0;//inicia o saldo zerado
    totalClientes++;
    Console.WriteLine($"Cliente cadastrado com sucesso");
    Console.WriteLine($"Pressione <Enter> para continuar ...");
    Console.ReadLine();
    
    
}

void ListarCliente()
{

    //     == Lista de Clientes ==
    // 0 - Eduardo | Saldo: R$ 0,00
    // 1 - Marcos | Saldo: R$ 0,00
    Console.WriteLine($"== LISTA DE CLIENTE");
    for (int i = 0; i < totalClientes; i++)
    {
        Console.WriteLine($"{i} - {nomes[i]} | saldo: R$ {saldos[i]}");
        
    }
    

    Console.WriteLine($"Clique em <Enter para continuar>");
    Console.ReadLine();
}

void Depositar()
{
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {
        return;
    }
    
    Console.Write($"Valor para depósito: ");
    double valorDeposito = double.Parse(Console.ReadLine());
    saldos[idCliente] += valorDeposito;
    Console.WriteLine($"Depósito de R$ {valorDeposito} realizado!");

    Console.WriteLine($"Clique em <Enter para continuar>");
    Console.ReadLine();
}

void Transferir()
{
    //buscar cliente - conta de origem
    //buscar cliente - conta de destino
    //pedir o valor do saque
    // verificar se a conta de oritem tem saldo pra transferir
    //se tiver, trasfere (debita saldo da conta origem e adiciona saldo na conta destino)

    Console.WriteLine($"== Transferência ==");
    Console.WriteLine($"Conta de origem: ");
    int idClienteOrigem = BuscarCliente();
    if (idClienteOrigem == -1)
    {//não existe
        return;
    }

    Console.WriteLine($"Conta de Origem: ");
    int idClienteDestino = BuscarCliente();
    if (idClienteDestino == -1)
    {//não existe
        return;
    }
    Console.Write($"Valor para transferir: ");
    double valor = double.Parse(Console.ReadLine());

    if (saldos[idClienteOrigem] >= valor)
    {//tem saldo para transferir
        saldos[idClienteOrigem] -= valor;
        saldos[idClienteDestino] += valor;
        Console.WriteLine($"Transferência concluída!");
    } else
    {//não tem saldo
        Console.WriteLine($"Saldo insuficiente!");
    }
}

void Sacar()
{
    //buscar o cliente
    int idCliente = BuscarCliente();
    if (idCliente == -1)
    {//cliente não existe
        return;
    }

    // pedir o valor do saque
    Console.Write($"Valor do saque: ");
    double valorSolicitado = double.Parse(Console.ReadLine());

    // validar se pode sacar ou não
    if (saldos[idCliente] >= valorSolicitado)
    {//saldo permite saque

        // atualizar o saldo da conta - debita o dinheiro da conta do cliente
        saldos[idCliente] -= valorSolicitado;
        Console.WriteLine($"Saque realizado com sucesso!");
    } else
    {
        Console.WriteLine($"Saldo insuficiente");
    }
    
    Console.WriteLine($"Clique em <Enter para continuar>");
    Console.ReadLine();
}

int BuscarCliente()
{
    ListarCliente();//desenha/exibe a lista de clientes
    Console.Write($"Digite o número do cliente: ");
    int idCliente = int.Parse(Console.ReadLine());//posição do array onde ele está
    
    if(idCliente < 0 || idCliente >= totalClientes)
    {
        Console.WriteLine($"Cliente não encontrado");
        return -1;//cliente não encontrado
    }

    return idCliente; // retorna o id do cliente cadastrado
}