using System;

namespace Persistence.Models
{
    public partial class Hitos
    {
        public int IdHito { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool? Pago { get; set; }
        public string Contexto { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaConcrecion { get; set; }
        public int? IdProyecto { get; set; }
        public int? IdFecha { get; set; }

        public virtual FechasHitos IdFechaNavigation { get; set; }
        public virtual Proyectos IdProyectoNavigation { get; set; }
    }
}
