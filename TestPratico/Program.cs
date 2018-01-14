using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPratico
{
    class Program
    {
        static void Main(string[] args)
        {
            string rua = "jose martins";
            Contato pq = new Contato(new Residencial());
            pq.Rua = rua;
            pq.Logradouro(rua);

            Console.ReadKey();

            Console.WriteLine("Nome da rua :" + rua);
        }
    }
}
