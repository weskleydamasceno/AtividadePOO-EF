using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Atividade2EFCore
{
    public class ContaCorrente
    {
        public int ContaCorrenteId { get; set; }
        public decimal Taxa { get; set; }
        public int ContaId { get; set; }

        [ForeignKey("ContaId")]
        public virtual Conta Conta { get; set; }
    }
}
