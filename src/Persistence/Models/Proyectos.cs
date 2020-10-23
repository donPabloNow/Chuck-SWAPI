using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Proyectos
    {
        public Proyectos()
        {
            Actividades = new HashSet<Actividades>();
            AsignacionesDeProyectos = new HashSet<AsignacionesDeProyectos>();
            Hitos = new HashSet<Hitos>();
            HojaDeTiempos = new HashSet<HojaDeTiempos>();
        }

        public int IdProyecto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaCierre { get; set; }
        public int? HorasVendidas { get; set; }
        public int? HorasPresupuestoInterno { get; set; }
        public decimal? Presupuesto { get; set; }
        public decimal? PresupuestoInterno { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaFinalizacion { get; set; }
        public int? IdCliente { get; set; }
        public bool? InformarEnReporteStatus { get; set; }
        public int? PresupuestoHorasMensualInterno { get; set; }
        public int? PresupuestoHorasMensualCliente { get; set; }

        public virtual Clientes IdClienteNavigation { get; set; }
        public virtual ICollection<Actividades> Actividades { get; set; }
        public virtual ICollection<AsignacionesDeProyectos> AsignacionesDeProyectos { get; set; }
        public virtual ICollection<Hitos> Hitos { get; set; }
        public virtual ICollection<HojaDeTiempos> HojaDeTiempos { get; set; }
    }
}
