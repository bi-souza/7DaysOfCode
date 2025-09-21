using ListaProdutos.Services;

namespace ListaProdutos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var lista = new ListaDeProdutos();
            lista.AdicionarItem("Macarrao", 10);
            lista.AdicionarItem("Cebola", 5);
            lista.AdicionarItem("Tomate", 120);
            lista.AdicionarItem("Suco de Laranja", 30);

            lista.ListarProdutos();
        }
    }
}