// See https://aka.ms/new-console-template for more information
using System.Text;

Queue<int> pedidosPendentes = new Queue<int>();
Stack<int> pedidosConcluidos = new Stack<int>();

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
            Console.WriteLine("Sistema de Processamento de Pedidos de Restaurante");
            Console.WriteLine();
            Console.WriteLine("Opção 1 - Adicionar Pedido");
            Console.WriteLine("Opção 2 - Preparar Pedido");
            Console.WriteLine("Opção 3 - Visualizar Pedidos Pendentes");
            Console.WriteLine("Opção 4 - Visualizar Pedidos Concluídos");            
            Console.WriteLine("Opção 5 - Sair ");

            Console.WriteLine();
            Console.Write("Informe uma opção: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AdicionarPedido();
                    break;
                case "2":
                    PrepararPedido();
                    break;
                case "3":
                    VisualizarPedidosPendentes();
                    break;
                case "4":
                    VisualizarPedidosConcluidos();
                    break;                
                case "5":
                    Console.Clear();
                    Console.WriteLine("Obrigado por Utilizar o Sistema!");
                    programaExecutando = false;
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    Console.ReadKey();
                    break;
            }

        } while (opcao != "5");

    }

    void AdicionarPedido()
    {
        int numeroPedido = 0;

        try
        {
            foreach (int ultimoPedido in pedidosPendentes)
            {
                numeroPedido = ultimoPedido;
            }            
        } 
        catch (InvalidOperationException ex)
        {
            return;         
        }
        finally
        {
            numeroPedido++;

            pedidosPendentes.Enqueue(numeroPedido);

            Console.WriteLine("Pedido adicionado com sucesso!");
            Console.ReadKey();
        }
    }

    void PrepararPedido()
    {
        int numeroPedido = 0;
        try
        {
            numeroPedido = pedidosPendentes.Peek();
        } 
        catch(InvalidOperationException ex)
        {
            Console.WriteLine("Não tem nenhum pedido para preparar!");
            return;
        }

        pedidosConcluidos.Push(numeroPedido);

        pedidosPendentes.Dequeue();

        Console.WriteLine("Pedido preparado!");
        Console.ReadKey();
    }

    void VisualizarPedidosPendentes()
    {
        if (pedidosPendentes.Count == 0)
        {
            Console.WriteLine("Nenhum pedido pendente!");
        }
        else
        {
            Console.WriteLine("Fila de Pedidos Pendentes: ");
            foreach (int pedido in pedidosPendentes)
            {
                Console.WriteLine(pedido);
            }
        }        
        Console.ReadKey();
    }

    void VisualizarPedidosConcluidos()
    {
        if (pedidosConcluidos.Count == 0)
        {
            Console.WriteLine("Nenhum pedido concluído!");
        }
        else
        {
            Console.WriteLine("Pilha de Pedidos Concluidos: ");
            foreach (int pedido in pedidosConcluidos)
            {
                Console.WriteLine(pedido);
            }
        }        
        Console.ReadKey();
    }    
}