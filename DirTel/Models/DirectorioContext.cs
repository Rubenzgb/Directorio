using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DirTel.Models
{
    public partial class DirectorioContext : DbContext
    {
        public DirectorioContext()
        {
        }

        public DirectorioContext(DbContextOptions<DirectorioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Contacto> Contactos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("name=DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contacto>(entity =>
            {
                entity.ToTable("Contacto");

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(50)
                    .HasColumnName("apellido_Materno");

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(50)
                    .HasColumnName("apellido_Paterno");

                entity.Property(e => e.Genero)
                    .HasMaxLength(15)
                    .HasColumnName("genero");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .HasColumnName("nombre");

                entity.Property(e => e.TelefonoCelular)
                    .HasMaxLength(50)
                    .HasColumnName("telefonoCelular");

                entity.Property(e => e.TelefonoFijo)
                    .HasMaxLength(50)
                    .HasColumnName("telefonoFijo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
