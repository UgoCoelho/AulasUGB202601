// See https://aka.ms/new-console-template for more information
using ConceitosPOO;

Console.WriteLine("Hello, World!");

Cliente cliente = new Cliente();
Console.WriteLine("Digite seu nome: ");
cliente.Nome = Console.ReadLine();
Console.WriteLine($"Nome do cliente: {cliente.Nome}");

Console.WriteLine("Digite seu Cpf: ");
cliente.Cpf = Console.ReadLine();
Console.WriteLine($"Nome do cliente: {cliente.Cpf}");