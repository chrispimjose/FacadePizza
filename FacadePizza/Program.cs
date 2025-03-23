namespace FacadePizza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cria a fachada da pizzaria
            PizzariaFacade pizzaria = new PizzariaFacade();

            // Cliente faz um pedido simples
            Console.WriteLine("Cliente faz pedido:");
            pizzaria.FazerPedido("Mussarela");

            Console.WriteLine(); // Linha em branco

            // Cliente faz outro pedido
            Console.WriteLine("Cliente faz outro pedido:");
            pizzaria.FazerPedido("Calabresa");
        }
    }
}
