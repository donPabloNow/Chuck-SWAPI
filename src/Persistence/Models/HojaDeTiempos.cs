namespace Persistence.Models
{
    public partial class HojaDeTiempos
    {
        public int IdHojaDeTiempo { get; set; }
        public int IdJornada { get; set; }
        public int IdActividad { get; set; }
        public int IdProyecto { get; set; }
        public string Notas { get; set; }
        public decimal CantidadDeHoras { get; set; }

        public virtual Actividades IdActividadNavigation { get; set; }
        public virtual Jornadas IdJornadaNavigation { get; set; }
        public virtual Proyectos IdProyectoNavigation { get; set; }
    }
}
