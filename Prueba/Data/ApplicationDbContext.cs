using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Persona> Socio{ get; set; }
        public virtual DbSet<Cuenta> Cuenta{ get; set; }
        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Persona>(a =>
            {
                a.HasKey(e => e.Cedula);

                a.Property(e => e.Nombre)
                //.IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

                a.Property(e => e.Apellido)
               //.IsRequired()
               .HasMaxLength(100)
               .IsUnicode(false);

                a.Property(e => e.Direccion)
               //.IsRequired()
               .HasMaxLength(250)
               .IsUnicode(false);

            });

            builder.Entity<Cuenta>(a =>
            {
                a.HasKey(e => e.Numero);

                a.Property(e => e.SaldoTotal)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

                a.Property(e => e.CodigoSocio)
               .IsRequired()
               .HasMaxLength(100)
               .IsUnicode(false);

                a.Property(e => e.Estado);
               //.IsRequired()
               //.HasMaxLength(250)
               //.IsUnicode(false);


            });


        }
    }
}
