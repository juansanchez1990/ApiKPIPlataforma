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

        public virtual DbSet<Comodin_Cajeros> Comodin_Cajeros { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<Log_Usuarios> Log_Usuarios { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Usuarios_KPI> Usuarios_KPI { get; set; }

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

            modelBuilder.Entity<Departamento>()
                .Property(e => e.Departamento1)
                .IsUnicode(false);

            modelBuilder.Entity<Log_Usuarios>()
                .Property(e => e.Usuario)
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
