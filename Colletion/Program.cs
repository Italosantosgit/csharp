using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colletion
{
    class Program
    {

        public class Aluno{
           public int idAluno;
           public string nome;
        }       

        static void Main(string[] args)
        {
            var alunos = new List<Aluno>();
            alunos.Add(new Aluno(){ idAluno = 1, nome = "italo"});
            alunos.Add(new Aluno(){ idAluno = 2, nome = "mateus"});
            foreach(Aluno alu in alunos)    
            {
                
                Console.WriteLine("ID do Aluno :" + alu.idAluno.ToString());
                Console.WriteLine("Nome do Aluno :" + alu.nome);
                Console.WriteLine("-----------------------------------");
            //linq
                var qry = from alun in alunos
                          where alun.nome.Contains("italo")
                          select alun;
                foreach (Aluno al in qry)
                {
                    Console.WriteLine(al.idAluno.ToString() +" - "+ al.nome);
                }

                Console.ReadLine();

            }

            

                
        }

        

    }
}
