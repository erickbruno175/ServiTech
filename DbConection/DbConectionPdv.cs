using Microsoft.EntityFrameworkCore;
using ServiTech.Model.ModelLocalidade;

namespace ServiTech.DbConection
{
    public class DbConectionPdv : DbContext
    {
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Bairro> Bairro { get; set; }
        public DbSet<Model.Produto> Produtos { get; set; }
        public DbSet<Model.Fornecedor> Fornecedores { get; set; }
        public DbSet<Model.Grupo> Grupos { get; set; }
        public DbSet<Model.SubGrupo> SubGrupos { get; set; }

        public DbSet<Model.FormaPagamento> FormaPagamentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ServiTechDB;Integrated Security=True;Encrypt=False;"
            );
        }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Produto → Fornecedor
            modelBuilder.Entity<Model.Produto>()
                .HasOne(p => p.Fornecedor)
                .WithMany(f => f.Produtos)
                .HasForeignKey(p => p.FornecedorId)
                .OnDelete(DeleteBehavior.Restrict);

            // Produto → Grupo
            modelBuilder.Entity<Model.Produto>()
                .HasOne(p => p.Grupo)
                .WithMany(g => g.Produtos)
                .HasForeignKey(p => p.GrupoId)
                .OnDelete(DeleteBehavior.Restrict);

            // Produto → SubGrupo
            modelBuilder.Entity<Model.Produto>()
                .HasOne(p => p.SubGrupo)
                .WithMany(s => s.Produtos)
                .HasForeignKey(p => p.SubGrupoId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}
