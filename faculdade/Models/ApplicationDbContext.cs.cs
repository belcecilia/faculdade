//using Microsoft.EntityFrameworkCore;
//namespace faculdade.Models
//{
//public class ApplicationDbContext : DbContext
//{
//public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
//{
//}
//public DbSet<Student> Students { get; set; }
//internal bool TestConnection()
//{
//throw new NotImplementedException();
//       }
//  }
//}
using Microsoft.EntityFrameworkCore;

namespace faculdade.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasKey(s => s.IdEstudante); // Configura a propriedade Id como chave primária
        }
    }
}