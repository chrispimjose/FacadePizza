using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePizza.Implementacao
{
    // Classe que cuida de preparar a massa
    public class Cozinha
    {
        public void PrepararMassa()
        {
            Console.WriteLine("Preparando a massa da pizza.");
        }

        public void AdicionarIngredientes(string sabor)
        {
            Console.WriteLine($"Adicionando ingredientes para pizza de {sabor}.");
        }
    }
}
