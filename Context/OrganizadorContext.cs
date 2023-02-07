using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estoque_Caixa.Models;
using Microsoft.EntityFrameworkCore;

namespace Estoque_Caixa.Context
{
    public class OrganizadorContext : DbContext
    {
         public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Produto>().Property(p => p.PrecoUnit).HasPrecision(14, 2);

            modelBuilder.Entity<Produto>().Property(p => p.DataCadastro).HasPrecision(3);
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<PedidoVenda> PedidoVendas { get; set; }
        
    

    }
}