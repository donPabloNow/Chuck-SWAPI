using System;

namespace Persistence.Models
{
    public partial class PermissionToRole
    {
        public Guid RoleId { get; set; }
        public int PermissionId { get; set; }

        public virtual Role Role { get; set; }
    }
}
