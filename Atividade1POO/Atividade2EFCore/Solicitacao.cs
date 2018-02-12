using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade2EFCore
{
    public class Solicitacao
    {
        public Solicitacao()
        {
            ClienteSolicitacoes = new List<ClienteSolicitacao>();
        }

        public int SolicitacaoId { get; set; }

        public virtual ICollection<ClienteSolicitacao> ClienteSolicitacoes { get; set; }
    }
}
