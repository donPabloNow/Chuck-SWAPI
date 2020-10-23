namespace Persistence.Models
{
    public partial class UbicacionOficinasDiveria
    {
        public int IdUbicacion { get; set; }
        public decimal? Latitud { get; set; }
        public decimal? Longitud { get; set; }
        public int? Tolerancia { get; set; }
    }
}
