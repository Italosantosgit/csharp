using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPratico
{
    public enum TipoContato { Celular = 0, TelefonaResidencial = 1, TelefoneComercial = 2 };

    public enum TipoCasa { Casa = 0, Comercial = 1 };

    public class Contato
    {

        private TipoContato tipoContato;
        private TipoCasa tipoCasa;
        private TipoResidencia tiporesidencia;

        public Contato(TipoResidencia tipo)
        {
            this.tiporesidencia = tipo;
        }

        public void Logradouro(string rua)
        {
            this.tiporesidencia.Logradouro(rua);
        }


        

        public string Rua;
      

        public Contato(string rua)
        {
            this.Rua = rua;
           
        }


    }

    public abstract class TipoResidencia
    {
        public abstract void Logradouro(string rua);
    }

    public class Residencial : TipoResidencia
    {
        public override void Logradouro(string rua)
        {
            Console.WriteLine("Fui enviado de uma Residencia" + rua);
        }
    }

    public class Comercial : TipoResidencia
    {
        public override void Logradouro(string rua)
        {
            Console.WriteLine("Fui enviado de uma Comercio" + rua);
        }
    }

    public class EscolhaResidencia
    {
        public static TipoResidencia TipoResidencia(TipoCasa tipocasa)
        {
            switch (tipocasa)
            {
                case TipoCasa.Casa:
                    return new Residencial();
                case TipoCasa.Comercial:
                    return new Comercial();
                default:
                    return null;
            }
        }

    }
}
