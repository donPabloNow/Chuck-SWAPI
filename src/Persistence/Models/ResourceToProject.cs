namespace Persistence.Models
{
    public partial class ResourceToProject
    {
        public int ProjectId { get; set; }
        public int ResourceId { get; set; }
        public int Id { get; set; }

        public virtual Recursos Resource { get; set; }
    }
}
