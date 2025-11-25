using Encapsulamento;

/*float dinheiro =200;

ContaBancaria contaEdu = new ContaBancaria();
ContaBancaria contaGabs = new ContaBancaria(dinheiro);

contaEdu.Depositar(dinheiro);

System.Console.WriteLine($"Novo saldo da conta R$ {contaEdu.GetSaldo()}");
System.Console.WriteLine($"Novo saldo da conta R$ {contaGabs.GetSaldo()}");

contaEdu.saque(100);
System.Console.WriteLine($"Saldo apos saque do edu: R$ {contaEdu.GetSaldo()}");*/



Carros carro1 = new Carros();
carro1.DefinirMarca("porshe");
carro1.DefinirModelo("911");
carro1.Acelerar(100);
Console.WriteLine($"Marca: {carro1.ObterMarca()}");
Console.WriteLine($"Modelo: {carro1.ObterModelo()}");
Console.WriteLine($"Velocidade Atual: {carro1.ObterVelocidade()}km/h");