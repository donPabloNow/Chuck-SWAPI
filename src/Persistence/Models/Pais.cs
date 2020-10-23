using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Pais
    {
        public Pais()
        {
            Clientes = new HashSet<Clientes>();
        }

        public int IdPais { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Clientes> Clientes { get; set; }
    }
}
