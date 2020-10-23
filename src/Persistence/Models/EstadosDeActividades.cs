using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class EstadosDeActividades
    {
        public EstadosDeActividades()
        {
            ActividadesEstados = new HashSet<ActividadesEstados>();
        }

        public int IdEstado { get; set; }
        public string Nombre { get; set; }
        public int? Orden { get; set; }

        public virtual ICollection<ActividadesEstados> ActividadesEstados { get; set; }
    }
}
