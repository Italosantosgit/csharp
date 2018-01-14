using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypes
{
    class Program
    {

        enum acessorio { Sapato, Bolsa, Cinto, Carteira, Colar }

        static void Main(string[] args)
        {
            int i = 10;
            string a = "OK";
            char ch = 'X';

            float ff = 10.89F;
            double dd = 90.9876;

            decimal dec = 10.88M;

            bool bl = true;

            int item = (int)acessorio.Cinto;

            //implicit conversion
            int i1 = 10;
            long i2 = i1;

            //Explicit Conversion
            double d1 = 10.9;
            int d2 = (int)d1;

            //int.TryParse(
            string txt = "999";
            int num;
            bool res = int.TryParse(txt, out num);
            if (res == false)
            {
            }
            string texto = "x";
            int num2;
            if (int.TryParse(texto, out num2))
            {
            }
            Console.WriteLine(num);
            Console.WriteLine(num2);


            //int.Parse(
            string text = "400";
            //double d3 = int.Parse(text);
            double d3 = double.Parse(text);
            Console.WriteLine(d3);

            //Convert.
            string txt1 = "500";
            int num4 = Convert.ToInt32(txt1);
            Console.WriteLine(num4 + "convert");

            //DataTime
            string now = "13/11/2017";
            // Use TryParse on the DateTime type to parse a date.
            DateTime parsed;
            if (DateTime.TryParse(now, out parsed))
            {
                Console.WriteLine(parsed + " Data");
            }


            Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}
