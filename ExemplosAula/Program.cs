// See https://aka.ms/new-console-template for more information

//primeira aula 10/02/2026
// iCalyca

int num1 = 20;
int num2 = 22;
int soma = num1 + num2;

Console.WriteLine($"a soma dos numeros {num1} e {num2} é: " + soma);


int idade;
bool idadeValida = false;
while (!idadeValida)
{
    Console.WriteLine("digite a sua idade: ");
    try
    {
        idade = Convert.ToInt32(Console.ReadLine());
        idadeValida = true;   
        if (idade >= 18 && idade <= 80)
        {
            Console.WriteLine("Você pode tirar CNH");
        }
        else
        {
            Console.WriteLine("você ainda não pode tirar habilitação");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("o valor infrmado deve ser em algarismos algébricos, NÚMEROS!");
    }
}


//modifique a aplicação para que solicite ao usuario informar o nome e imprima o nome informado
 
Console.WriteLine("informe o seu nome: ");
var nome = Console.ReadLine();
Console.WriteLine("Bem vindo! " + nome);


//informe se a idade do usuario é um nomero par ou impar

int idadedois;
Console.WriteLine("digite a sua idade: ");
idadedois = Convert.ToInt32(Console.ReadLine());

if (idadedois % 2 == 0)
{
    Console.WriteLine("sua idade é um numero par!");
}
else
{
    Console.WriteLine("sua idade é um numero impar!");
}
