using System;

namespace Persistence.Models
{
    public partial class ActividadesEstados
    {
        public int IdActividadEstados { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public DateTime? FechaEgreso { get; set; }
        public int? NroDeEstado { get; set; }
        public int? IdActividad { get; set; }
        public int? IdEstado { get; set; }

        public virtual EstadosDeActividades IdEstadoNavigation { get; set; }
    }
}
