using System;
using Atividade2EFCore;
using System.Linq;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
            {
                context.Set<Agencia>().RemoveRange(context.Agencias);
                context.Set<Banco>().RemoveRange(context.Bancos);
                context.Set<Cliente>().RemoveRange(context.Clientes);
                context.Set<ClienteSolicitacao>().RemoveRange(context.ClienteSolicitacoes);
                context.Set<Conta>().RemoveRange(context.Contas);
                context.Set<ContaCorrente>().RemoveRange(context.ContasCorrente);
                context.Set<ContaPoupanca>().RemoveRange(context.ContasPoupanca);
                context.Set<Solicitacao>().RemoveRange(context.Solicitacoes);

                while(true)
                {
                    Console.WriteLine("Escolha a operacao desejada:");
                    Console.WriteLine("1 - Cadastrar cliente;");
                    Console.WriteLine("2 - Atualizar cliente;");
                    Console.WriteLine("3 - Listar clientes");
                    Console.WriteLine("4 - Excluir cliente");
                    Console.WriteLine("0 - Sair");

                    var leitura = Convert.ToInt32(Console.ReadLine());

                    if (leitura == 1)
                    {
                        Console.WriteLine("Digite o nome do cliente:");
                        var CliNome = Console.ReadLine();
                        var newCliente = new Cliente { Nome = CliNome };
                        context.Add(newCliente);
                        context.SaveChanges();
                        Console.WriteLine("Cliente cadastrado com sucesso!");
                    }
                    else if (leitura == 2)
                    {
                        Console.WriteLine("Digite o Id do cliente");
                        var cliId = Convert.ToInt32(Console.ReadLine());
                        var clientes = context.Set<Cliente>();
                        foreach (var c in clientes) { }
                        var cli = context.Set<Cliente>().First(c => c.ClienteId == cliId);
                        Console.WriteLine($"ID: {cli.ClienteId} | Cliente: {cli.Nome}");

                        Console.WriteLine("Digite um novo nome para o cliente:");
                        var newNome = Console.ReadLine();
                        cli.Nome = newNome;
                        context.SaveChanges();
                        Console.WriteLine($"ID: {cli.ClienteId} | Cliente: {cli.Nome}");
                        clientes = context.Clientes;
                        
                    }
                    else if (leitura == 3)
                    {
                        var clientes = context.Set<Cliente>();
                        foreach (var cli in clientes)
                        {
                            Console.WriteLine($"ID: {cli.ClienteId} | Cliente: {cli.Nome}");
                        }
                    }
                    else if (leitura == 4)
                    {
                        Console.WriteLine("Digite o Id do cliente");
                        var cliId = Convert.ToInt32(Console.ReadLine());
                        var clientes = context.Set<Cliente>();
                        foreach (var c in clientes) { }
                        var cli = context.Set<Cliente>().First(c => c.ClienteId == cliId);
                        Console.WriteLine($"ID: {cli.ClienteId} | Cliente: {cli.Nome}");
                        context.Remove(cli);
                        context.SaveChanges();
                        Console.WriteLine("Cliente removido com sucesso!");
                    }
                    else if (leitura == 0)
                    {
                        return;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
