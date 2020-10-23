namespace Persistence.Models
{
    public partial class AdjuntosActividades
    {
        public int IdActividad { get; set; }
        public int IdAdjunto { get; set; }

        public virtual Adjuntos IdAdjuntoNavigation { get; set; }
    }
}
