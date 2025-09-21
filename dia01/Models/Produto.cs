using System.Collections;

namespace ListaProdutos.Models
{

    public class Produto
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, int quantidade)
        {
            this.Nome = nome;
            this.Quantidade = quantidade;
        }
    }
}