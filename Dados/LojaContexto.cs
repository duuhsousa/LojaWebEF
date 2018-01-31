using LojaWebEF.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaWebEF.Dados
{
    public class LojaContexto:DbContext
    {
        public LojaContexto(DbContextOptions<LojaContexto> options):base(options){}

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Pedido> Pedido { get; set; }

        /// <summary>
        /// ESSA CLASSE SOBRESCREVE A CLASSE OnModelCreating QUE ESTA NA CLASSE DBCONTEXT
        /// AGORA SUA CLASSE OnModelCreating TEM OS ATRIBUTOS QUE VOCE PRECISA
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Produto>().ToTable("Produto");
            modelBuilder.Entity<Pedido>().ToTable("Pedido");
        }
    }
}