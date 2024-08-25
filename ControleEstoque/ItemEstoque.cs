using System;

namespace ControleEstoque
{
    public class ItemEstoque
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public string Fabricante { get; set; }
        public int Quantidade { get; set; } = 0;

        public ItemEstoque(string nome, double preco, string tipo, string descricao, string fabricante)
        {
            Nome = nome;
            Preco = preco;
            Tipo = tipo;
            Descricao = descricao;
            Fabricante = fabricante;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Preço: {Preco:C}, Tipo: {Tipo}, Descrição: {Descricao}, Fabricante: {Fabricante}, Quantidade: {Quantidade}";
        }

        public void AdicionarQuantidade(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverQuantidade(int quantidade)
        {
            if (quantidade <= Quantidade)
            {
                Quantidade -= quantidade;
            }
            else
            {
                Console.WriteLine("Quantidade insuficiente.");
            }
        }
    }
}