using System;

namespace Persistence.Models
{
    public partial class CargaHoraria
    {
        public int IdCargaHoraria { get; set; }
        public int? IdRecurso { get; set; }
        public decimal? CargaHoraria1 { get; set; }
        public DateTime? VigenteDesde { get; set; }
    }
}
