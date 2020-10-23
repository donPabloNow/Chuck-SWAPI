using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public partial class Clientes
    {
        public Clientes()
        {
            Proyectos = new HashSet<Proyectos>();
        }

        public int IdCliente { get; set; }
        public string NombreRazonSocial { get; set; }
        public string Codigo { get; set; }
        public string Domicilio { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int? IdPais { get; set; }
        public DateTime? FechaAlta { get; set; }

        public virtual Pais IdPaisNavigation { get; set; }
        public virtual ICollection<Proyectos> Proyectos { get; set; }
    }
}
