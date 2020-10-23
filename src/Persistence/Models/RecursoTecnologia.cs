using System;

namespace Persistence.Models
{
    public partial class RecursoTecnologia
    {
        public int Id { get; set; }
        public DateTime? FechaInicio { get; set; }
        public int? Nivel { get; set; }
        public int? IdRecurso { get; set; }
        public int? IdTecnologia { get; set; }

        public virtual Tecnologias IdTecnologiaNavigation { get; set; }
    }
}
