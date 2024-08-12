using System.Data.Entity;
using CRUD_EF_Framework.Models;

namespace CRUD_EF_Framework.Models
{
    public class CRUD_EF_FrameworkContext : DbContext
    {
        public CRUD_EF_FrameworkContext() : base("name=DefaultConnection")
        {
        }

        // DbSet para las entidades
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configuración de la clave primaria para Product
            modelBuilder.Entity<Product>()
                .HasKey(p => p.ProductId);

            // Configuración de la clave primaria para Category
            modelBuilder.Entity<Category>()
                .HasKey(c => c.CategoryId);

            // Configuración de la relación uno a muchos entre Category y Product
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOptional() // Con Optional es opcional, se puede quitar si siempre es requerido
                .HasForeignKey(p => p.CategoryId); // Asegúrate de que Product tenga CategoryId como FK

            base.OnModelCreating(modelBuilder);
        }
    }
}
