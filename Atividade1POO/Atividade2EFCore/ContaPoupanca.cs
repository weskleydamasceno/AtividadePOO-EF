using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Atividade2EFCore
{
    public class ContaPoupanca
    {
        public int ContaPoupancaId { get; set; }
        public decimal Juros { get; set; }
        public DateTime DataAniversario { get; set; }
        public int ContaId { get; set; }

        [ForeignKey("ContaId")]
        public virtual Conta Conta { set; get; }
    }
}
