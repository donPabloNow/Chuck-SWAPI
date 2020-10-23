using System;

namespace Persistence.Models
{
    public partial class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public int? IdRecurso { get; set; }

        public virtual Recursos IdRecursoNavigation { get; set; }
    }
}
