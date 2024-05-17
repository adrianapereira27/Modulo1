// See https://aka.ms/new-console-template for more information
using System.Text;

#region Calculadora
/*
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
*/
#endregion

#region Menu

List<string> nomes = new List<string>();
List<string> datasNascimento = new List<string>();
List<string> estadosCivis = new List<string>();
bool programaExecutando = true;

while (programaExecutando)
{    
    Menu();

    void Menu()
    {
        string opcao = "";

        do
        {
            Console.Clear();
            Console.WriteLine("Exercicio Menu Lista");
            Console.WriteLine();
            Console.WriteLine("Opção 1 - Adicione um nome ");
            Console.WriteLine("Opção 2 - Adicione uma data de nascimento ");
            Console.WriteLine("Opção 3 - Adicione um estado civil ");
            Console.WriteLine("Opção 4 - Liste todos os nomes ");
            Console.WriteLine("Opção 5 - Liste todas as datas de nascimento ");
            Console.WriteLine("Opção 6 - Liste todos os estados civis ");
            Console.WriteLine("Opção 7 - Sair ");

            Console.WriteLine();
            Console.Write("Informe uma opção: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AdicionarNome();
                    break;
                case "2":
                    AdicionarDataNascimento();
                    break;
                case "3":
                    AdicionarEstadoCivil();
                    break;
                case "4":
                    ListarNomes();
                    break;
                case "5":
                    ListarDatasNascimento();
                    break;
                case "6":
                    ListarEstadosCivis();
                    break;
                case "7":
                    Console.Clear();
                    Console.WriteLine("Obrigado por Utilizar o Sistema!");
                    programaExecutando = false;
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    Console.ReadKey();                    
                    break;
            }

        } while (opcao != "7");

    }

    void AdicionarNome()
    {
        char continuar = 'n';
        do
        {
            Console.WriteLine("Informe um nome: ");
            string nome = Console.ReadLine();
            nomes.Add(nome);
            Console.Write("Deseja incluir outro nome (s/n): ");
            continuar = Convert.ToChar(Console.ReadLine());
        } while (continuar != 'n');
       
    }
    void AdicionarDataNascimento()
    {
        char continuar = 'n';
        do
        {
            Console.WriteLine("Informe uma data de nascimento: ");
            string dataNascimento = Console.ReadLine();
            datasNascimento.Add(dataNascimento);
            Console.Write("Deseja incluir outra data de nascimento (s/n): ");
            continuar = Convert.ToChar(Console.ReadLine());
        } while (continuar != 'n');
    }

    void AdicionarEstadoCivil()
    {
        char continuar = 'n';
        do
        {
            Console.WriteLine("Informe um estado civil: ");
            string estadoCivil = Console.ReadLine();
            estadosCivis.Add(estadoCivil);
            Console.Write("Deseja incluir outro estado civil (s/n): ");
            continuar = Convert.ToChar(Console.ReadLine());
        } while (continuar != 'n');
    }

    void ListarNomes()
    {
        Console.WriteLine("Lista dos nomes digitados: ");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }
        Console.ReadKey();
    }
    void ListarDatasNascimento()
    {
        Console.WriteLine("Lista das datas de nascimento digitadas: ");
        foreach (string data in datasNascimento)
        {
            Console.WriteLine(data);
        }
        Console.ReadKey();
    }
    void ListarEstadosCivis()
    {
        Console.WriteLine("Lista dos estados civis digitados: ");
        foreach (string estadoCivil in estadosCivis)
        {
            Console.WriteLine(estadoCivil);
        }
        Console.ReadKey();
    }
}
#endregion


