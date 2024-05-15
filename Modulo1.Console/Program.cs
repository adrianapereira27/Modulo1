// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Informe seu nome: ");
string nome = Console.ReadLine();

Console.WriteLine("Informe sua idade: ");
int idade = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Informe seu cargo: ");
string cargo = Console.ReadLine();

DateTime now = DateTime.Now;
String hoje = now.ToString("G");

Console.WriteLine($"Olá, bem vindo {nome}, você tem {idade} anos, seu cargo é {cargo}, hoje é {hoje}");

Console.ReadKey();