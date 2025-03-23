using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadePizza.Implementacao;
using static System.Net.Mime.MediaTypeNames;

namespace FacadePizza
{
    // Classe que simplifica o pedido de pizza (fachada)
    public class PizzariaFacade
    {
        // Referências aos subsistemas
        private Cozinha cozinha;
        private Forno forno;
        private Entrega entrega;

        // Construtor inicializa os subsistemas
        public PizzariaFacade()
        {
            cozinha = new Cozinha();
            forno = new Forno();
            entrega = new Entrega();
        }

        // Método simples para o cliente pedir uma pizza
        public void FazerPedido(string sabor)
        {
            Console.WriteLine($"Processando pedido de pizza de {sabor}:");
            cozinha.PrepararMassa();        // Passo 1: Prepara a massa
            cozinha.AdicionarIngredientes(sabor); // Passo 2: Adiciona os ingredientes
            forno.AssarPizza();            // Passo 3: Assa a pizza
            entrega.EntregarPizza();       // Passo 4: Entrega ao cliente
            Console.WriteLine("Pedido concluído!");
        }
    }
}
