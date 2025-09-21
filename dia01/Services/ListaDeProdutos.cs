using System;
using System.Collections.Generic;
using System.Linq;
using ListaProdutos.Models;

namespace ListaProdutos.Services
{
    public class ListaDeProdutos
    {
        public List<Produto> Produtos { get; set; } = new List<Produto>();

        public void AdicionarItem(string nome, int quantidade)
        {
            Produtos.Add(new Produto(nome, quantidade));
        }

        public void RemoverItem(string nome)
        {
            var produto = Produtos.FirstOrDefault(p => p.Nome == nome);
            if (produto != null)
            {
                Produtos.Remove(produto);
            }
        }

        public void ListarProdutos()
        {
            foreach (var p in Produtos)
            {
                Console.WriteLine($"{p.Nome} = {p.Quantidade}");
            }
        }

    }
}