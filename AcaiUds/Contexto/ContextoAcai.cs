using AcaiUds.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcaiUds.Contexto
{
    public class ContextoAcai: DbContext
    {

        public ContextoAcai(DbContextOptions<ContextoAcai> options)
            : base(options)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Tamanho>()
            //    .HasOne(p => p.Sabor)
            //    .WithMany(c => c.Tamanho);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            
        }

        public DbSet<Sabores> Sabores { get; set; }
        public DbSet<Tamanho> Tamanho { get; set; }
        //public DbSet<Adicionais> Adicionais { get; set; }
        public DbSet<Pedido> Pedidos  { get; set; }
        //public DbSet<personalizacao> Personalizacao { get; set; }

    }
}
