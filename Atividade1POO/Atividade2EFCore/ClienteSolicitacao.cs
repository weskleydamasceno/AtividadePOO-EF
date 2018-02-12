using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade2EFCore
{
    public class ClienteSolicitacao
    {
        public int ClienteSolicitacaoId { get; set; }
        public int ClientId { get; set; }
        public int SolicitacaoId { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Solicitacao Solicitacao { get; set; }
    }
}
