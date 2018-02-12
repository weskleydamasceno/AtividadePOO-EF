using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade2EFCore
{
    public class Banco
    {
        public Banco()
        {
            Agencias = new List<Agencia>();
        }

        public int BancoId { get; set; }

        public virtual ICollection<Agencia> Agencias { get; set; }
    }
}
