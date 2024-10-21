using Poo1;


/*var cachorro = new Cachorro(8, "Bob");
Console.WriteLine($"Meu cachorro se chama {cachorro.Nome} e ele tem {cachorro.Idade} anos.");*/

try
{
	var conta = new Poupanca("Gilberto", 1500);
	Console.WriteLine($"O saldo de {conta.Proprietario} é {conta.Saldo}!");

	conta.Deposito(500);
	Console.WriteLine($"O saldo de {conta.Proprietario} é {conta.Saldo}!");

	conta.Saque(200);
	Console.WriteLine($"O saldo de {conta.Proprietario} é {conta.Saldo}!");

	conta.Saque(3000);
	Console.WriteLine($"O saldo de {conta.Proprietario} é {conta.Saldo}!");
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}
