using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ControleEstoque
{
    public class GerenciadorEstoque
    {
        private List<ItemEstoque> _itens = new List<ItemEstoque>();

        public void AdicionarItem()
        {
            Console.Clear();
            try
            {
                Console.WriteLine("Informe o Nome do Produto:");
                string nome = Console.ReadLine() ?? "";
                if (string.IsNullOrEmpty(nome)) throw new Exception("Nome não pode ser vazio.");

                Console.WriteLine("Informe o Preço do Produto:");
                if (!double.TryParse(Console.ReadLine(), out double preco)) throw new Exception("Preço inválido:");

                Console.WriteLine("Informe o Tipo do Produto:");
                string tipo = Console.ReadLine() ?? "";
                if (string.IsNullOrEmpty(tipo)) throw new Exception("Tipo não pode ser vazio.");

                Console.WriteLine("Informe a Descrição do Produto:");
                string descricao = Console.ReadLine() ?? "";
                if (string.IsNullOrEmpty(descricao)) throw new Exception("Descrição não pode ser vazia."); ;

                Console.WriteLine("Informe a Fabricante do Produto:");
                string fabricante = Console.ReadLine() ?? "";
                if (string.IsNullOrEmpty(fabricante)) throw new Exception("Fabricante não pode ser vazio.");

                var item = new ItemEstoque(nome, preco, tipo, descricao, fabricante);

                _itens.Add(item); // adiciona item na lista 

                Console.WriteLine("Item adicionado com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
                Console.ReadKey();
            }
        }

        public void ListarItens()
        {
            Console.Clear();
            if (_itens.Count == 0)
            {
                Console.WriteLine("Nenhum item no estoque.");
                Console.ReadKey();
                return;
            }

            for (int i = 0; i < _itens.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_itens[i]}");
            }
            Console.ReadKey();
        }

        public ItemEstoque? BuscarItem(int index)
        {
            // Verifica se o índice é válido (dentro do range da lista)
            if (index >= 0 && index < _itens.Count)
            {
                return _itens[index];  // Retorna o item no índice especificado
            }
            else
            {
                return null;
            }
        }

        public void RemoverItem()
        {
            Console.Clear();
            Console.WriteLine("Informe a posição do item para remover do estoque: ");
            try
            {
                if (!int.TryParse(Console.ReadLine(), out int posicao))
                {
                    throw new Exception("Posição inválida.");
                }

                var item = BuscarItem(posicao);
                if (item != null)
                {
                    Console.WriteLine(item.ToString());
                    Console.WriteLine("Deseja remover este item? (S/N)");
                    string? resposta = Console.ReadLine() ?? "N";
                    if (resposta.Equals("S", StringComparison.OrdinalIgnoreCase))
                    {
                        _itens.Remove(item);
                        Console.WriteLine("Item removido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Item não removido.");
                    }
                }
                else
                {
                    Console.WriteLine("Item não encontrado.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            Console.ReadKey();
        }

        public void EntradaEstoque()
        {
            Console.Clear();

            try
            {
                Console.WriteLine("Informe o nome do item para entrada de estoque:");
                if (!int.TryParse(Console.ReadLine(), out int posicao))
                {
                    throw new Exception("Posição inválida.");
                }
                var item = BuscarItem(posicao);
                if (item != null)
                {
                    Console.WriteLine(item.ToString());
                    Console.WriteLine("Informe a quantidade de entrada:");
                    int quantidade = int.Parse(Console.ReadLine() ?? "0");
                    item.Quantidade = quantidade;
                    Console.WriteLine($"Entrada de {quantidade} unidades do item [{item.Nome}] efetuada com sucesso!");
                }
                else
                {
                    Console.WriteLine("Item não encontrado.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

            Console.ReadKey();
        }

        public void SaidaEstoque()
        {
            Console.Clear();

            try
            {
                Console.WriteLine("Informe o nome do item para saída de estoque:");
                if (!int.TryParse(Console.ReadLine(), out int posicao))
                {
                    throw new Exception("Posição inválida.");
                }
                var item = BuscarItem(posicao);
                if (item != null)
                {
                    Console.WriteLine(item.ToString());
                    Console.WriteLine("Informe a quantidade de saída:");
                    int quantidade = int.Parse(Console.ReadLine() ?? "0");
                    if (quantidade <= item.Quantidade)
                    {
                        item.Quantidade -= quantidade;
                        Console.WriteLine($"Saída de {quantidade} unidades do item [{item.Nome}] efetuada com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Quantidade de saída superior à quantidade em estoque.");
                    }
                }
                else
                {
                    Console.WriteLine("Item não encontrado.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}