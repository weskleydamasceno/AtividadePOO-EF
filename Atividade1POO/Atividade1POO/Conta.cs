using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade1POO
{
    public abstract class Conta
    {
        private decimal saldo;
        private string titular;

        public decimal Saldo { get; set; }
        public string Titular { get; set; }

        public Conta(string t)
        {
            titular = t;
        }

        public virtual int Id
        {
            get;
        }

        public virtual void Depositar(decimal valor)
        {
            saldo += valor;
        }

        public virtual void Sacar(decimal valor)
        {
            if (valor <= saldo)
                saldo -= valor;
        }
    }

    

    
}
