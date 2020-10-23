using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Recursos
    {
        public Recursos()
        {
            AsignacionesDeActividades = new HashSet<AsignacionesDeActividades>();
            AsignacionesDeProyectos = new HashSet<AsignacionesDeProyectos>();
            CostoRecurso = new HashSet<CostoRecurso>();
            RecursoCategoria = new HashSet<RecursoCategoria>();
            User = new HashSet<User>();
        }

        public int IdRecurso { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool? UsaSeguridadIntegradaAd { get; set; }
        public string NombreCompleto { get; set; }
        public decimal? MinHorasDia { get; set; }
        public decimal? MinHorasMes { get; set; }
        public string AdGui { get; set; }
        public DateTime? FechaBaja { get; set; }
        public DateTime? FechaInicio { get; set; }

        public virtual ICollection<AsignacionesDeActividades> AsignacionesDeActividades { get; set; }
        public virtual ICollection<AsignacionesDeProyectos> AsignacionesDeProyectos { get; set; }
        public virtual ICollection<CostoRecurso> CostoRecurso { get; set; }
        public virtual ICollection<RecursoCategoria> RecursoCategoria { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
