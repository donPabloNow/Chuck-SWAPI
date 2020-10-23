namespace Persistence.Models
{
    public partial class Configuraciones
    {
        public string EmailOrigen { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string SmtpServer { get; set; }
        public string Puerto { get; set; }
        public string EmailAdministrador { get; set; }
        public int? NumDiasPorRecurso { get; set; }
        public int? IdConfiguracion { get; set; }
        public string BasePathAdjuntos { get; set; }
        public string ActividadesRaizProyecto { get; set; }
    }
}
