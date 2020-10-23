using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class FechasHitos
    {
        public FechasHitos()
        {
            Hitos = new HashSet<Hitos>();
        }

        public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Orden { get; set; }
        public string Motivo { get; set; }
        public int? MilestoneId { get; set; }

        public virtual ICollection<Hitos> Hitos { get; set; }
    }
}
