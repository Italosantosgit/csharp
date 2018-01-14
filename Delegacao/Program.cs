using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegacao
{
    // UI
    class Program
    {
        static void Main(string[] args)
        {

            var valor = 100;
            // Injeção de dependência (DI) / Inversão de Controle (IoC)
            Pedido pedido = new Pedido(new Cartao());
            pedido.Fechar(valor);
            Console.ReadLine();
        }
    }
}
