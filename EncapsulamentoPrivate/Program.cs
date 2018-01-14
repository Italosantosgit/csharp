using System;
using BancoDoBrasil;

namespace EncapsulamentoPrivate
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta(TipoConta.ContaCorrente, "123");
            conta.Depositar(100);
            conta.Sacar(10);
            Console.WriteLine(conta.getSaldo().ToString());
            Console.Write(conta.Tipo.ToString());
            Console.ReadLine(); 

        }
    }
}
