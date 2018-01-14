using System;
using Herença.Entidades;

namespace Herença
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica Pf = new PessoaFisica();
            Pf.Codigo = 123;
            Pf.Nome  = "ITALO";
            Pf.CPF = "123456789876543";
            Pf.Mostrar();

            PessoaJuridica pj = new PessoaJuridica();
            pj.Codigo = 234;
            pj.Nome = "Luiz";
            pj.CNPJ = "098765674856";
            pj.Mostrar();

            Console.ReadLine();
        }
    }
}
