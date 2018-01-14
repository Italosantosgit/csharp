using System;

namespace Pedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido(new Boleto()); // injeto a dependência
            double valor = 2000;
            pedido.Pagar(valor);

            Pedido pedido2 = new Pedido(new Cartao());
            double valor2 = 12200;
            pedido2.Pagar(valor2);

            Console.ReadLine();

        }
    }
}
