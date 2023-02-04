using ApiPlatformKPI.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ApiPlatformKPI.Controllers
{
    public partial class ModelKPI : DbContext
    {
        public ModelKPI()
            : base("name=ModelKPI")
        {
        }

        public virtual DbSet<Auxiliar_Deli> Auxiliar_Deli { get; set; }
        public virtual DbSet<Categorias_Confiabilidad> Categorias_Confiabilidad { get; set; }
        public virtual DbSet<Comodin_Cajeros> Comodin_Cajeros { get; set; }
        public virtual DbSet<Confiabilidad_Inventarios> Confiabilidad_Inventarios { get; set; }
        public virtual DbSet<Horas_Cajeros> Horas_Cajeros { get; set; }
        public virtual DbSet<KPI_Nombres_Reportes> KPI_Nombres_Reportes { get; set; }
        public virtual DbSet<KPI_ProgramaDeli> KPI_ProgramaDeli { get; set; }
        public virtual DbSet<KPI_ProgramaFruVer> KPI_ProgramaFruVer { get; set; }
        public virtual DbSet<KPI_ReporteCajeros> KPI_ReporteCajeros { get; set; }
        public virtual DbSet<KPI_ReporteDeli> KPI_ReporteDeli { get; set; }
        public virtual DbSet<Log_Usuarios> Log_Usuarios { get; set; }
        public virtual DbSet<Marcajes_Impulsadores> Marcajes_Impulsadores { get; set; }
        public virtual DbSet<Margen_Categorias> Margen_Categorias { get; set; }
        public virtual DbSet<RegistroStaFe> RegistroStaFe { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Top300Productos> Top300Productos { get; set; }
        public virtual DbSet<Top500Productos> Top500Productos { get; set; }
        public virtual DbSet<Usuarios_KPI> Usuarios_KPI { get; set; }

        public virtual DbSet<Documentacion> Documentacion { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comodin_Cajeros>()
                .Property(e => e.Comodin)
                .IsUnicode(false);

            modelBuilder.Entity<Comodin_Cajeros>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Comodin_Cajeros>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Comodin_Cajeros>()
                .Property(e => e.Intervalo)
                .IsUnicode(false);

            modelBuilder.Entity<Horas_Cajeros>()
                .Property(e => e.Number_Cajero)
                .IsUnicode(false);

            modelBuilder.Entity<KPI_Nombres_Reportes>()
                .Property(e => e.Nombre_KPI)
                .IsUnicode(false);

            modelBuilder.Entity<KPI_Nombres_Reportes>()
                .Property(e => e.Imagen)
                .IsUnicode(false);

            modelBuilder.Entity<KPI_ProgramaDeli>()
                .Property(e => e.Dia)
                .IsUnicode(false);

            modelBuilder.Entity<KPI_ProgramaDeli>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<KPI_ProgramaDeli>()
                .Property(e => e.Producto)
                .IsUnicode(false);

            modelBuilder.Entity<KPI_ProgramaDeli>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<KPI_ProgramaDeli>()
                .Property(e => e.TipoSemana)
                .IsUnicode(false);

            modelBuilder.Entity<KPI_ProgramaFruVer>()
                .Property(e => e.Dia)
                .IsUnicode(false);

            modelBuilder.Entity<KPI_ProgramaFruVer>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<KPI_ProgramaFruVer>()
                .Property(e => e.Producto)
                .IsUnicode(false);

            modelBuilder.Entity<KPI_ProgramaFruVer>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<KPI_ProgramaFruVer>()
                .Property(e => e.TipoSemana)
                .IsUnicode(false);

            modelBuilder.Entity<KPI_ReporteCajeros>()
                .Property(e => e.Semana)
                .IsUnicode(false);

            modelBuilder.Entity<KPI_ReporteCajeros>()
                .Property(e => e.Cajero)
                .IsUnicode(false);

            modelBuilder.Entity<KPI_ReporteDeli>()
                .Property(e => e.Dia)
                .IsUnicode(false);

            modelBuilder.Entity<KPI_ReporteDeli>()
                .Property(e => e.NombreCategoria)
                .IsUnicode(false);

            modelBuilder.Entity<KPI_ReporteDeli>()
                .Property(e => e.Intervalo)
                .IsUnicode(false);

            modelBuilder.Entity<Log_Usuarios>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Marcajes_Impulsadores>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Marcajes_Impulsadores>()
                .Property(e => e.Hora)
                .IsUnicode(false);

            modelBuilder.Entity<Marcajes_Impulsadores>()
                .Property(e => e.Dia)
                .IsUnicode(false);

            modelBuilder.Entity<Marcajes_Impulsadores>()
                .Property(e => e.Tipo_Marcaje)
                .IsUnicode(false);

            modelBuilder.Entity<Marcajes_Impulsadores>()
                .Property(e => e.Proveedor)
                .IsUnicode(false);

            modelBuilder.Entity<Margen_Categorias>()
                .Property(e => e.Codigo_Categoria)
                .IsUnicode(false);

            modelBuilder.Entity<Margen_Categorias>()
                .Property(e => e.Categoria_Nueva)
                .IsUnicode(false);

            modelBuilder.Entity<RegistroStaFe>()
                .Property(e => e.Producto)
                .IsUnicode(false);

            modelBuilder.Entity<RegistroStaFe>()
                .Property(e => e.Responsable)
                .IsUnicode(false);

            modelBuilder.Entity<RegistroStaFe>()
                .Property(e => e.Motivo)
                .IsUnicode(false);

            modelBuilder.Entity<RegistroStaFe>()
                .Property(e => e.Evidencia)
                .IsUnicode(false);

            modelBuilder.Entity<Roles>()
                .Property(e => e.Rol)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios_KPI>()
                .Property(e => e.Nombre_Completo)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios_KPI>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios_KPI>()
                .Property(e => e.Contrasenia)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios_KPI>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios_KPI>()
                .Property(e => e.Celular)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios_KPI>()
                .Property(e => e.Foto)
                .IsUnicode(false);
        }
    }
}
