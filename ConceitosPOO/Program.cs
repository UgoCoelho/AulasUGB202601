// See https://aka.ms/new-console-template for more information
using ConceitosPOO;

Console.WriteLine("Hello, World!");

Cliente cliente;
Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine("Digite seu cpf: ");
string cpf = Console.ReadLine();
    while (true)
    {
        Console.WriteLine("Digite seu cpf: ");
        cpf = Console.ReadLine();

        if (cpf.Length == 11)
        {
            string cpfFormatado = Convert.ToUInt64(cpf)
                .ToString(@"000\.000\.000\-00");

            Console.WriteLine($"CPF do cliente: {cpfFormatado}");
            break; 
        }
        else
        {
            Console.WriteLine("CPF inválido! CPF deve ter 11 digitos!");
        }
    }
cliente = new Cliente(nome, cpf);
// cliente.Nome = "";
Console.WriteLine($"Nome do cliente: {cliente.Nome}");


Agencia agencia = new Agencia(13);
Console.WriteLine("Digite o nome da agencia: ");
agencia.Nome = Console.ReadLine();
Console.WriteLine($"Nome da agencia: {agencia.Nome}");

Console.WriteLine("Digite o Telefone da agencia: ");
agencia.Telefone = Console.ReadLine();
Console.WriteLine($"Telefone da agencia: {agencia.Telefone}");
Console.WriteLine($"Numero da agencia: {agencia.Numero}");

Conta conta;
Console.WriteLine("Digite o numero da sua conta: ");
long numero = int.Parse( Console.ReadLine() );
Console.WriteLine("Digite o saldo inicial da sua conta: ");
decimal saldo = decimal.Parse( Console.ReadLine() );

conta = new Conta(numero, saldo);
Console.WriteLine($"Numero da conta: {conta.Numero}");
Console.WriteLine($"saldo inicial da conta: {conta.Saldo}");

Console.WriteLine("Digite o valor que deseja depositar: ");
decimal deposito = decimal.Parse( Console.ReadLine() );
conta.Deposito(deposito);
Console.WriteLine($"saldo apos o deposito: {conta.Saldo}");
Console.WriteLine("Digite o valor que deseja sacar");
decimal saque = decimal.Parse(Console.ReadLine());
conta.Saque(saque);
Console.WriteLine($"saldo apos o saque: {conta.Saldo}");

