using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Atividade2EFCore
{
    public class Agencia
    {
        public Agencia()
        {
            Contas = new List<Conta>();
            Solicitacoes = new List<Solicitacao>();
        }

        public int AgenciaID { get; set; }
        public int ContaId { get; set; }
        public int BancoId { get; set; }

        public virtual ICollection<Conta> Contas { get; set; }
        [ForeignKey("BancoId")]
        public virtual Banco Banco { get; set; }

        public virtual ICollection<Solicitacao> Solicitacoes { get; set; }
    }
}
