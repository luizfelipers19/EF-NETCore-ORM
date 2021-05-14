using CpmPedidos.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpmPedidos.Repository
{
    public class ApplicationDbContext : DbContext
    {
        //exemplo de DbSet de uma entidade (singular) para ser transformada em tabela (plural)
        //  public virtual DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        // public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<CategoriaProduto> CategoriasProdutos { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        public DbSet<PromocaoProduto> PromocoesProdutos {get;set; }

        public DbSet<Combo> Combos { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // DbContext.Pedidos.

            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

        }

        public ApplicationDbContext()
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

    }
}
