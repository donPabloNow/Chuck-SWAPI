namespace Persistence.Models
{
    public partial class AsignacionesDeProyectos
    {
        public int IdAsignacion { get; set; }
        public int IdRecurso { get; set; }
        public int IdProyecto { get; set; }

        public virtual Proyectos IdProyectoNavigation { get; set; }
        public virtual Recursos IdRecursoNavigation { get; set; }
    }
}
