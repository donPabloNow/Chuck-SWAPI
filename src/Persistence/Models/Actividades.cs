using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Actividades
    {
        public Actividades()
        {
            HojaDeTiempos = new HashSet<HojaDeTiempos>();
        }

        public int IdActividad { get; set; }
        public int? IdActividadPadre { get; set; }
        public int? IdProyecto { get; set; }
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        public decimal? HorasEstimadas { get; set; }
        public decimal? HorasReales { get; set; }
        public DateTime? FechaBaja { get; set; }

        public virtual Proyectos IdProyectoNavigation { get; set; }
        public virtual ICollection<HojaDeTiempos> HojaDeTiempos { get; set; }
    }
}
