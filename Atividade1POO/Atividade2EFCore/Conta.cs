using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Atividade2EFCore
{
    public class Conta
    {
        public int ContaId { get; set; }
        public decimal Saldo { get; set; }
        public string Titular { get; set; }
        public int AgenciaId { get; set; }
        public int ClienteId { get; set; }

        [ForeignKey("AgenciaId")]
        public virtual Agencia Agencia { get; set; }
        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }
    }
}
