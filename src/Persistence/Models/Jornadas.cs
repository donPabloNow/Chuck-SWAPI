using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Jornadas
    {
        public Jornadas()
        {
            HojaDeTiempos = new HashSet<HojaDeTiempos>();
        }

        public int IdJornada { get; set; }
        public int IdRecurso { get; set; }
        public DateTime? Fecha { get; set; }
        public DateTime? FechaHoraInicio { get; set; }
        public DateTime? FechaHoraFin { get; set; }
        public DateTime? FechaHoraCierre { get; set; }
        public decimal? TotalHoras { get; set; }
        public decimal? IntervalosDeTiempos { get; set; }
        public DateTime? FechaInforme { get; set; }
        public int? IdUbicacion { get; set; }
        public int? IdEstado { get; set; }

        public virtual ICollection<HojaDeTiempos> HojaDeTiempos { get; set; }
    }
}
