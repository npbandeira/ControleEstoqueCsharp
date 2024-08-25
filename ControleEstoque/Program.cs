// See https://aka.ms/new-console-template for more information
using System;
using System.Threading.Tasks;
using ControleEstoque;

class Program
{
    static void Main()
    {
        var gerenciador = new GerenciadorEstoque();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("CONTROLE DE ESTOQUE - INFORMÁTICA");
            Console.WriteLine("MENU PRINCIPAL:");
            Console.WriteLine("[1] - Cadastrar Produto");
            Console.WriteLine("[2] - Listar Produtos");
            Console.WriteLine("[3] - Remover Produtos");
            Console.WriteLine("[4] - Entrada Estoque");
            Console.WriteLine("[5] - Saída Estoque");
            Console.WriteLine("[0] - Sair");
            Console.Write("\nEscolha uma opção: ");

            string? escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    gerenciador.AdicionarItem();
                    break;
                case "2":
                    gerenciador.ListarItens();
                    break;
                case "3":
                    gerenciador.RemoverItem();
                    break;
                case "4":
                    gerenciador.EntradaEstoque();
                    break; // Encerra o programa
                case "5":
                    gerenciador.SaidaEstoque();
                    break; // Encerra o programa
                case "0":
                    return; // Encerra o programa
                default:
                    Console.WriteLine("Opção: " + escolha);
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    Console.ReadKey();
                    break;
            }
        }

    }
}

