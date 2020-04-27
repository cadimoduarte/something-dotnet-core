using Microsoft.EntityFrameworkCore;

namespace SomethingWebApi.Models
{
    public class SomethingContext : DbContext
    {
        public SomethingContext(DbContextOptions<SomethingContext> options) : base(options)
        {
        }

        public DbSet<Something> Somethings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder
                .HasDefaultSchema("example");
        }
    }
}