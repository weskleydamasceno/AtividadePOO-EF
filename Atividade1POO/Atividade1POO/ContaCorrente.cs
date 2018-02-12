using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade1POO
{
    public class ContaCorrente : Conta
    {
        //representa a taxa fixa de operações bancárias
        public const decimal taxa = 0.10M;

        public ContaCorrente(string t) : base(t)
        {

        }

        public override int Id
        {
            get;
        }

        public override void Depositar(decimal valor)
        {
            decimal desconto = valor * taxa;
            base.Depositar(valor - desconto);
        }

        public override void Sacar(decimal valor)
        {
            decimal desconto = valor * taxa;
            base.Sacar(valor - desconto);
        }
    }
}
