using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Tecnologias
    {
        public Tecnologias()
        {
            RecursoTecnologia = new HashSet<RecursoTecnologia>();
        }

        public int IdTecnologia { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<RecursoTecnologia> RecursoTecnologia { get; set; }
    }
}
