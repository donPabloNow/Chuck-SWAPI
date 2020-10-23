namespace Persistence.Models
{
    public partial class ResourceToActivity
    {
        public int ActivityId { get; set; }
        public int ResourceId { get; set; }

        public virtual Recursos Resource { get; set; }
    }
}
