using Microsoft.EntityFrameworkCore;
using ServiTech.Model;
using ServiTech.Model.ModelGrupo;
using ServiTech.Model.ModelLocalidade;
using ServiTech.Model.ModelTributacao;

namespace ServiTech.DbConection
{
    public class DbConectionPdv : DbContext
    {
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Bairro> Bairro { get; set; }
        public DbSet<Model.Produto> Produto { get; set; }
        public DbSet<Model.Fornecedor> Fornecedores { get; set; }
        public DbSet<Model.ModelGrupo.Grupo> Grupos { get; set; }
        public DbSet<Model.ModelGrupo.SubGrupo> SubGrupos { get; set; }
        public DbSet<Model.Servico> Servicos { get; set; }
        public DbSet<Model.FormaPagamento> FormaPagamentos { get; set; }

        public DbSet<NCM> Ncms { get; set; }

        public DbSet<Model.CondicaoPagamento> CondicaoPagamentos { get; set; }


        public DbSet<Model.UnidadeMedida> UnidadeMedidas { get; set; }
        public DbSet<Model.ModelTributacao.CFOP> CFOPs { get; set; }
        public DbSet<Model.ModelTributacao.CSTCSOSN> CSTCSOSNs { get; set; }

        public DbSet<Model.Marca> Marcas { get; set; }

        public DbSet<Model.ModelTransportadora.Transportadora> Transportadoras{ get; set; }

        public DbSet<Model.AtividadeEconomica> AtividadeEconomicas{ get; set; }


        public DbSet<Model.ModelTributacao.OrigemMercadoria> OrigemMercadorias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ServiTechDB;Integrated Security=True;Encrypt=False;"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Produto → Fornecedor
            modelBuilder.Entity<Produto>()
           .HasOne(p => p.Fornecedor)
           .WithMany(f => f.Produtos)
           .HasForeignKey(p => p.FornecedorId)
           .OnDelete(DeleteBehavior.Restrict);

            // Produto → Grupo
            modelBuilder.Entity<Produto>()
                .HasOne(p => p.Grupo)
                .WithMany(g => g.produto)
                .HasForeignKey(p => p.GrupoId)
                .OnDelete(DeleteBehavior.Restrict);

            // Produto → SubGrupo
            modelBuilder.Entity<Produto>()
                .HasOne(p => p.SubGrupo)
                .WithMany(s => s.Produtos)
                .HasForeignKey(p => p.SubGrupoId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }

    }
}
