using System;

namespace Lambda
{
    public delegate void PagarNotify (double valor);

    public class Pedido
    {
        // ponteiro para um método
        // forma de injetar código no meu framework
        // código da implementação vem de fora
        public event PagarNotify PagarEvent; // alguém deve apontar

        public void Pagar(double valor)
        {
            // delegação
            this.PagarEvent(valor);         
        }
    }
   
}
