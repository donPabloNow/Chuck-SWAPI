namespace Persistence.Models
{
    public partial class VPresupuesto
    {
        public decimal? TotalHoras { get; set; }
        public string Proyecto { get; set; }
        public int? HorasVendidas { get; set; }
        public int? HorasPresupuestoInterno { get; set; }
        public decimal? Presupuesto { get; set; }
        public decimal? PresupuestoInterno { get; set; }
        public int IdProyecto { get; set; }
    }
}
