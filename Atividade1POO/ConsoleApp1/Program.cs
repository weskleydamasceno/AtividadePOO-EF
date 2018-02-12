using System;
using Atividade1POO;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var data = new DateTime(2018, 02, 01);
            ContaPoupanca cp = new ContaPoupanca(10.0M, data, "João");
            cp.Depositar(500.00M);
            cp.Sacar(400.00M);
            Console.Write(cp.Titular);

            ContaCorrente cc = new ContaCorrente("João");
            cc.Depositar(1500.00M);
            cc.Sacar(750.00M);

            Console.ReadKey();
        }
    }
}
