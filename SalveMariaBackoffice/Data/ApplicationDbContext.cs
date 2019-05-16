using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SalveMariaBackoffice.Models;

namespace SalveMariaBackoffice.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public virtual DbSet<Alertas> Alertas { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Alertas>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Nome);
                entity.Property(x => x.Endereco);
                entity.Property(x => x.Latitude);
                entity.Property(x => x.Longitude);


            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Nome);
                entity.Property(x => x.Endereco);
                entity.Property(x => x.Telefone);
                entity.Property(x => x.CPF);
                entity.Property(x => x.Email);
                entity.Property(x => x.Login);
                entity.Property(x => x.Senha);



            });

        }
    }
}
