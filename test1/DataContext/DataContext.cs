using Microsoft.EntityFrameworkCore;
using test1.Model;

namespace test1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Etudiant> Etudiant { get; set; }
    }
}
