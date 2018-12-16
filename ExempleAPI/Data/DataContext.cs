using ExempleAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace ExempleAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Article> Articles { get; set; }

    }
}
