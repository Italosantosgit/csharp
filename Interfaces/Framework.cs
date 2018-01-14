using System;

namespace SistemaNotificacao
{
    /*
     * Test de delegação com interface
     * 
    public class Noti 
    {
        private INotificacao _noti;
        
        public void Notificar(string Mensagem)
        {
      
     * delegação polimórfica
     * semelhante a um padrão State
     
            this._noti.Enviar(Mensagem);
        }

        public Noti(INotificacao noti)
        {
     
     * guardo internamente a forma de pagamento
     * que foi passada no construtor da classe
     * para que depois seja feita a delegação
     
            this._noti = noti;
        }
    }
    */

    public interface INotificacao
    {
        void Enviar(string Mensagem);
    }

    public abstract class Notificacao: INotificacao
    {
        public abstract void Enviar(string Mensagem);
    }

    public class EMail : Notificacao, INotificacao
    {
        public override void Enviar(string Mensagem)
        {
            Console.WriteLine("Enviando EMAIL: " + Mensagem);
        }
    }

    public class SMS : Notificacao, INotificacao
    {
        public override void Enviar(string Mensagem)
        {
            Console.WriteLine("Enviando SMS: " + Mensagem);
        }
    }

    public class Pessoa
    {
        public string Nome;
    }

    public class Funcionario : Pessoa, INotificacao
    {
        public void Enviar(string Mensagem)
        {
            Console.WriteLine("Pessoa está notificando: " + Mensagem);
        }
    }

}
