namespace Persistence.Models
{
    public partial class DiveriaTimesheetContext : DbContext
    {
        public DiveriaTimesheetContext()
        {
        }

        public DiveriaTimesheetContext(DbContextOptions<DiveriaTimesheetContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actividades> Actividades { get; set; }
        public virtual DbSet<ActividadesEstados> ActividadesEstados { get; set; }
        public virtual DbSet<Adjuntos> Adjuntos { get; set; }
        public virtual DbSet<AdjuntosActividades> AdjuntosActividades { get; set; }
        public virtual DbSet<AsignacionesDeActividades> AsignacionesDeActividades { get; set; }
        public virtual DbSet<AsignacionesDeProyectos> AsignacionesDeProyectos { get; set; }
        public virtual DbSet<CargaHoraria> CargaHoraria { get; set; }
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<CierreMes> CierreMes { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Configuraciones> Configuraciones { get; set; }
        public virtual DbSet<CostoRecurso> CostoRecurso { get; set; }
        public virtual DbSet<EstadosDeActividades> EstadosDeActividades { get; set; }
        public virtual DbSet<EstadosRecursos> EstadosRecursos { get; set; }
        public virtual DbSet<FechasHitos> FechasHitos { get; set; }
        public virtual DbSet<Feriados> Feriados { get; set; }
        public virtual DbSet<Hitos> Hitos { get; set; }
        public virtual DbSet<HojaDeTiempos> HojaDeTiempos { get; set; }
        public virtual DbSet<Jornadas> Jornadas { get; set; }
        public virtual DbSet<MantisMapping> MantisMapping { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<PermissionToRole> PermissionToRole { get; set; }
        public virtual DbSet<PresupuestoMesProyectos> PresupuestoMesProyectos { get; set; }
        public virtual DbSet<Proyectos> Proyectos { get; set; }
        public virtual DbSet<ProyectosTecnologias> ProyectosTecnologias { get; set; }
        public virtual DbSet<RecursoCategoria> RecursoCategoria { get; set; }
        public virtual DbSet<RecursoTecnologia> RecursoTecnologia { get; set; }
        public virtual DbSet<Recursos> Recursos { get; set; }
        public virtual DbSet<ResourceToActivity> ResourceToActivity { get; set; }
        public virtual DbSet<ResourceToProject> ResourceToProject { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RoleToUser> RoleToUser { get; set; }
        public virtual DbSet<Tecnologias> Tecnologias { get; set; }
        public virtual DbSet<UbicacionOficinasDiveria> UbicacionOficinasDiveria { get; set; }
        public virtual DbSet<Ubicaciones> Ubicaciones { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<VHojaDeTiempos> VHojaDeTiempos { get; set; }
        public virtual DbSet<VPresupuesto> VPresupuesto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=Diveria.Timesheet;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actividades>(entity =>
            {
                entity.HasKey(e => e.IdActividad)
                    .HasName("PK_Activides");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.HorasEstimadas).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.HorasReales).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.Actividades)
                    .HasForeignKey(d => d.IdProyecto)
                    .HasConstraintName("FK_Activides_Proyectos");
            });

            modelBuilder.Entity<ActividadesEstados>(entity =>
            {
                entity.HasKey(e => e.IdActividadEstados)
                    .HasName("PK__Activida__9A57FCF625869641");

                entity.Property(e => e.FechaEgreso).HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.ActividadesEstados)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK8689B4FCCBDBA08C");
            });

            modelBuilder.Entity<Adjuntos>(entity =>
            {
                entity.HasKey(e => e.IdAdjunto)
                    .HasName("PK__Adjuntos__8DEE306929572725");

                entity.Property(e => e.IdAdjunto).HasColumnName("idAdjunto");

                entity.Property(e => e.NombreArchivo).HasMaxLength(50);

                entity.Property(e => e.Path)
                    .HasColumnName("path")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<AdjuntosActividades>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.IdActividad).HasColumnName("idActividad");

                entity.Property(e => e.IdAdjunto).HasColumnName("idAdjunto");

                entity.HasOne(d => d.IdAdjuntoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdAdjunto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKB06211C3FEF60DA3");
            });

            modelBuilder.Entity<AsignacionesDeActividades>(entity =>
            {
                entity.HasKey(e => e.IdAsignacionActividad);

                entity.ToTable("Asignaciones_de_Actividades");

                entity.HasOne(d => d.IdRecursoNavigation)
                    .WithMany(p => p.AsignacionesDeActividades)
                    .HasForeignKey(d => d.IdRecurso)
                    .HasConstraintName("FK_Asignaciones_de_Actividades_Recursos");
            });

            modelBuilder.Entity<AsignacionesDeProyectos>(entity =>
            {
                entity.HasKey(e => e.IdAsignacion);

                entity.ToTable("Asignaciones_de_Proyectos");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.AsignacionesDeProyectos)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Asignaciones_de_Proyectos_Proyectos");

                entity.HasOne(d => d.IdRecursoNavigation)
                    .WithMany(p => p.AsignacionesDeProyectos)
                    .HasForeignKey(d => d.IdRecurso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Asignaciones_de_Proyectos_Recursos");
            });

            modelBuilder.Entity<CargaHoraria>(entity =>
            {
                entity.HasKey(e => e.IdCargaHoraria);

                entity.Property(e => e.CargaHoraria1)
                    .HasColumnName("CargaHoraria")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.VigenteDesde).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<Categorias>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__Categori__8A3D240C2D27B809");

                entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<CierreMes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Anio).HasColumnName("anio");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(255);

                entity.Property(e => e.Mes).HasColumnName("mes");
            });

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__Clientes__D594664230F848ED");

                entity.Property(e => e.Codigo).HasMaxLength(50);

                entity.Property(e => e.Domicilio).HasMaxLength(200);

                entity.Property(e => e.FechaAlta)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.NombreRazonSocial).HasMaxLength(250);

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.IdPais)
                    .HasConstraintName("FK2F1E8CDBD652E972");
            });

            modelBuilder.Entity<Configuraciones>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ActividadesRaizProyecto)
                    .HasColumnName("actividadesRaizProyecto")
                    .HasMaxLength(255);

                entity.Property(e => e.BasePathAdjuntos)
                    .HasColumnName("basePathAdjuntos")
                    .HasMaxLength(255);

                entity.Property(e => e.EmailAdministrador)
                    .HasColumnName("email_administrador")
                    .HasMaxLength(100);

                entity.Property(e => e.EmailOrigen)
                    .HasColumnName("email_origen")
                    .HasMaxLength(50);

                entity.Property(e => e.NumDiasPorRecurso).HasColumnName("num_dias_por_recurso");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50);

                entity.Property(e => e.Puerto)
                    .HasColumnName("puerto")
                    .HasMaxLength(50);

                entity.Property(e => e.SmtpServer)
                    .HasColumnName("smtpServer")
                    .HasMaxLength(50);

                entity.Property(e => e.Usuario)
                    .HasColumnName("usuario")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CostoRecurso>(entity =>
            {
                entity.HasKey(e => e.IdCostoRecurso)
                    .HasName("PK__CostoRec__D950FFB45165187F");

                entity.Property(e => e.Costo).HasColumnType("decimal(19, 5)");

                entity.HasOne(d => d.IdRecursoNavigation)
                    .WithMany(p => p.CostoRecurso)
                    .HasForeignKey(d => d.IdRecurso)
                    .HasConstraintName("FK7A4363B3E40F17CB");
            });

            modelBuilder.Entity<EstadosDeActividades>(entity =>
            {
                entity.HasKey(e => e.IdEstado)
                    .HasName("PK__EstadosD__FBB0EDC15DCAEF64");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Orden).HasColumnName("orden");
            });

            modelBuilder.Entity<EstadosRecursos>(entity =>
            {
                entity.HasKey(e => e.IdEstadoRecurso);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FechasHitos>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.MilestoneId).HasColumnName("Milestone_id");

                entity.Property(e => e.Motivo)
                    .HasColumnName("motivo")
                    .HasMaxLength(255);

                entity.Property(e => e.Orden).HasColumnName("orden");
            });

            modelBuilder.Entity<Feriados>(entity =>
            {
                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<Hitos>(entity =>
            {
                entity.HasKey(e => e.IdHito)
                    .HasName("PK__Hitos__7DED89B4403A8C7D");

                entity.Property(e => e.IdHito).HasColumnName("idHito");

                entity.Property(e => e.Contexto)
                    .HasColumnName("contexto")
                    .HasMaxLength(255);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(255);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(255);

                entity.Property(e => e.FechaConcrecion)
                    .HasColumnName("fechaConcrecion")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdFecha).HasColumnName("idFecha");

                entity.Property(e => e.IdProyecto).HasColumnName("idProyecto");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(255);

                entity.Property(e => e.Pago).HasColumnName("pago");

                entity.HasOne(d => d.IdFechaNavigation)
                    .WithMany(p => p.Hitos)
                    .HasForeignKey(d => d.IdFecha)
                    .HasConstraintName("FK4A16C0F5CBDE2297");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.Hitos)
                    .HasForeignKey(d => d.IdProyecto)
                    .HasConstraintName("FK4A16C0F5245D6B1D");
            });

            modelBuilder.Entity<HojaDeTiempos>(entity =>
            {
                entity.HasKey(e => e.IdHojaDeTiempo);

                entity.ToTable("Hoja_de_tiempos");

                entity.Property(e => e.CantidadDeHoras).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Notas).HasColumnType("text");

                entity.HasOne(d => d.IdActividadNavigation)
                    .WithMany(p => p.HojaDeTiempos)
                    .HasForeignKey(d => d.IdActividad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hoja_de_tiempos_Actividades");

                entity.HasOne(d => d.IdJornadaNavigation)
                    .WithMany(p => p.HojaDeTiempos)
                    .HasForeignKey(d => d.IdJornada)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hoja_de_tiempos_Jornadas");

                entity.HasOne(d => d.IdProyectoNavigation)
                    .WithMany(p => p.HojaDeTiempos)
                    .HasForeignKey(d => d.IdProyecto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hoja_de_tiempos_Proyectos");
            });

            modelBuilder.Entity<Jornadas>(entity =>
            {
                entity.HasKey(e => e.IdJornada)
                    .HasName("PK_Jornada");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraCierre).HasColumnType("date");

                entity.Property(e => e.FechaHoraFin).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraInicio).HasColumnType("datetime");

                entity.Property(e => e.FechaInforme)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IntervalosDeTiempos).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalHoras).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<MantisMapping>(entity =>
            {
                entity.HasKey(e => e.IdMapping)
                    .HasName("PK__MantisMa__431F509638996AB5");
            });

            modelBuilder.Entity<Pais>(entity =>
            {
                entity.HasKey(e => e.IdPais)
                    .HasName("PK__Pais__FC850A7B34C8D9D1");

                entity.Property(e => e.Descripcion).HasMaxLength(200);
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<PermissionToRole>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.PermissionId).HasColumnName("Permission_id");

                entity.Property(e => e.RoleId).HasColumnName("Role_id");

                entity.HasOne(d => d.Role)
                    .WithMany()
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK9E27A927324FA423");
            });

            modelBuilder.Entity<PresupuestoMesProyectos>(entity =>
            {
                entity.HasKey(e => e.IdPresupuestoMes);

                entity.Property(e => e.Importe).HasColumnType("money");
            });

            modelBuilder.Entity<Proyectos>(entity =>
            {
                entity.HasKey(e => e.IdProyecto);

                entity.Property(e => e.Descripcion).HasColumnType("text");

                entity.Property(e => e.FechaAlta).HasColumnType("datetime");

                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaCierre).HasColumnType("datetime");

                entity.Property(e => e.FechaFinalizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Presupuesto).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.PresupuestoInterno).HasColumnType("decimal(19, 5)");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Proyectos)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK8BA36D774D0A9A0B");
            });

            modelBuilder.Entity<ProyectosTecnologias>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<RecursoCategoria>(entity =>
            {
                entity.Property(e => e.FechaBaja).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");

                entity.Property(e => e.IdRecurso).HasColumnName("idRecurso");

                entity.HasOne(d => d.IdRecursoNavigation)
                    .WithMany(p => p.RecursoCategoria)
                    .HasForeignKey(d => d.IdRecurso)
                    .HasConstraintName("FKB5C2B9C4E40F17CB");
            });

            modelBuilder.Entity<RecursoTecnologia>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FechaInicio)
                    .HasColumnName("fechaInicio")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdRecurso).HasColumnName("idRecurso");

                entity.Property(e => e.IdTecnologia).HasColumnName("idTecnologia");

                entity.Property(e => e.Nivel).HasColumnName("nivel");

                entity.HasOne(d => d.IdTecnologiaNavigation)
                    .WithMany(p => p.RecursoTecnologia)
                    .HasForeignKey(d => d.IdTecnologia)
                    .HasConstraintName("FKF29F4DDFF7DAE5AC");
            });

            modelBuilder.Entity<Recursos>(entity =>
            {
                entity.HasKey(e => e.IdRecurso);

                entity.Property(e => e.AdGui)
                    .HasColumnName("AD_GUI")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("GUI del usuario en el active directory");

                entity.Property(e => e.FechaBaja)
                    .HasColumnName("fechaBaja")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaInicio)
                    .HasColumnName("fechaInicio")
                    .HasColumnType("datetime");

                entity.Property(e => e.Login)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MinHorasDia).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinHorasMes).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NombreCompleto)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsaSeguridadIntegradaAd).HasColumnName("UsaSeguridadIntegradaAD");
            });

            modelBuilder.Entity<ResourceToActivity>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ActivityId).HasColumnName("Activity_id");

                entity.Property(e => e.ResourceId).HasColumnName("Resource_id");

                entity.HasOne(d => d.Resource)
                    .WithMany()
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FKB5916AF2F751107F");
            });

            modelBuilder.Entity<ResourceToProject>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ProjectId).HasColumnName("Project_id");

                entity.Property(e => e.ResourceId).HasColumnName("Resource_id");

                entity.HasOne(d => d.Resource)
                    .WithMany()
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK71992B02C03F4146");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<RoleToUser>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.RoleId).HasColumnName("Role_id");

                entity.Property(e => e.UserId).HasColumnName("User_id");

                entity.HasOne(d => d.Role)
                    .WithMany()
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK232674041DFA049F");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK232674041737654E");
            });

            modelBuilder.Entity<Tecnologias>(entity =>
            {
                entity.HasKey(e => e.IdTecnologia)
                    .HasName("PK__Tecnolog__5ECD2D11619B8048");

                entity.Property(e => e.Descripcion).HasMaxLength(4000);
            });

            modelBuilder.Entity<UbicacionOficinasDiveria>(entity =>
            {
                entity.HasKey(e => e.IdUbicacion)
                    .HasName("PK__Ubicacio__778CAB1D339FAB6E");

                entity.Property(e => e.Latitud).HasColumnType("decimal(18, 16)");

                entity.Property(e => e.Longitud).HasColumnType("decimal(18, 16)");
            });

            modelBuilder.Entity<Ubicaciones>(entity =>
            {
                entity.HasKey(e => e.IdUbicacion);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.PasswordHash).HasMaxLength(255);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.IdRecursoNavigation)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.IdRecurso)
                    .HasConstraintName("FK564EC989E40F17CB");
            });

            modelBuilder.Entity<VHojaDeTiempos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vHojaDeTiempos");

                entity.Property(e => e.Actividad)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CantidadDeHoras).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraFin).HasColumnType("datetime");

                entity.Property(e => e.FechaHoraInicio).HasColumnType("datetime");

                entity.Property(e => e.Login)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreDia)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Notas).HasColumnType("text");

                entity.Property(e => e.Proyecto)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VPresupuesto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vPresupuesto");

                entity.Property(e => e.Presupuesto).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.PresupuestoInterno).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.Proyecto)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TotalHoras).HasColumnType("decimal(38, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
