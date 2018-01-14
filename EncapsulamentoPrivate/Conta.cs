using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDoBrasil
{
    enum TipoConta{ContaCorrente , ContaPoupanca};

    class Conta
    {
        private String Num;
        private double _Saldo;
        public TipoConta Tipo;
        
        //construtor
        public Conta(TipoConta tipo, string num)
        {
            this.Num = num;
            this.Tipo = tipo;
            this._Saldo = 0;
        }

        public void Sacar(double valor)
        {
            _Saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _Saldo += valor;
        }
        public double getSaldo()
        {
            return _Saldo;
        }
    }
}
