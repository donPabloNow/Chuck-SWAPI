using System;

namespace Persistence.Models
{
    public partial class VHojaDeTiempos
    {
        public DateTime? Fecha { get; set; }
        public int? Anio { get; set; }
        public int? Mes { get; set; }
        public int? Dia { get; set; }
        public string NombreDia { get; set; }
        public decimal CantidadDeHoras { get; set; }
        public string Notas { get; set; }
        public DateTime? FechaHoraInicio { get; set; }
        public DateTime? FechaHoraFin { get; set; }
        public string Login { get; set; }
        public string Proyecto { get; set; }
        public string Actividad { get; set; }
    }
}
