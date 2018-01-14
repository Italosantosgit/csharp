using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        //associaçao para uma abstração
        private static INotificacao notifica;

        static void Main(string[] args)
        {
            string Mensagem = "Olá Mundo Doido";
            notifica = new Funcionario();
            notifica.Enviar(Mensagem);//delegação
            Console.Read();
        }
    }
}
