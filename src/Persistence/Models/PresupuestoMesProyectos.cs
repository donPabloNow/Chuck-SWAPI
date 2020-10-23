namespace Persistence.Models
{
    public partial class PresupuestoMesProyectos
    {
        public int IdPresupuestoMes { get; set; }
        public int IdProyecto { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public int CantidadHoras { get; set; }
        public decimal Importe { get; set; }
        public int HorasEstimadasFaltantesTotal { get; set; }
    }
}
