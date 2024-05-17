// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Calculadora");

Console.WriteLine("Informe um numero: ");
decimal valor1 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Informe outro numero: ");
decimal valor2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Informe a operacao: ( +, -, * ou / )");
string operacao = Console.ReadLine();

string descricaoOperacao = "";
decimal resultado = 0;

switch (operacao) {
    case "+":
        resultado = valor1 + valor2;
        descricaoOperacao = "soma";
        break;
    case "-":
        resultado = valor1 - valor2;
        descricaoOperacao = "subtração";
        break;
    case "*":
        resultado = valor1 * valor2;
        descricaoOperacao = "multiplicação";
        break;
    case "/":        
        if (valor2 == 0)
        {
            Console.WriteLine("Operação indefinida");
        }
        else {
            resultado = valor1 / valor2;
            descricaoOperacao = "divisão";
        }        
        break;
    default:
        Console.WriteLine("Operação inválida");
        break;
}

if (descricaoOperacao != "")
{
    Console.WriteLine($"O resultado da {descricaoOperacao} é {resultado}");
}

Console.ReadKey();
    