using System;

namespace Persistence.Models
{
    public partial class RecursoCategoria
    {
        public int Id { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdRecurso { get; set; }

        public virtual Recursos IdRecursoNavigation { get; set; }
    }
}
