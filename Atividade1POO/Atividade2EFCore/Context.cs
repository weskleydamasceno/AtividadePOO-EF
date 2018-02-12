using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO;


namespace Atividade2EFCore
{
    public class Context : DbContext
    {
        public DbSet<Agencia> Agencias { get; set; }
        public DbSet<Banco> Bancos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ClienteSolicitacao> ClienteSolicitacoes { get; set; }
        public DbSet<Conta> Contas { get; set; }
        public DbSet<ContaCorrente> ContasCorrente { get; set; }
        public DbSet<ContaPoupanca> ContasPoupanca { get; set; }
        public DbSet<Solicitacao> Solicitacoes { get; set; }

        private static IConfigurationRoot Configuration;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-FTVDIB4\\WESKLEYSQL;Database=dbLP2;User Id=sa;Password=123456");
        }
    }
}
