using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade2EFCore
{
    public class Cliente
    {
        public Cliente()
        {
            Contas = new List<Conta>();
            ClienteSolicitacoes = new List<ClienteSolicitacao>();
        }

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public int ContaId { get; set; }

        public virtual ICollection<Conta> Contas { get; set; }
        public virtual ICollection<ClienteSolicitacao> ClienteSolicitacoes { get; set; }
    }
}
