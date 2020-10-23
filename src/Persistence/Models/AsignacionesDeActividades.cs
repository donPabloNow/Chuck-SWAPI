namespace Persistence.Models
{
    public partial class AsignacionesDeActividades
    {
        public int IdAsignacionActividad { get; set; }
        public int? IdActividad { get; set; }
        public int? IdRecurso { get; set; }

        public virtual Recursos IdRecursoNavigation { get; set; }
    }
}
