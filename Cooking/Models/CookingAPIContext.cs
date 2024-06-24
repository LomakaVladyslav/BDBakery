using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace Cooking.Models
{
    public class CookingAPIContext : DbContext
    {
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<AuthorReciept> AuthorReciepts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Reciept> Reciepts { get; set; }
        public virtual DbSet<Type> Types { get; set; }
        public virtual DbSet<Photos> Photos { get; set; }

        public CookingAPIContext(DbContextOptions<CookingAPIContext> options) : base(options)
        {
        }
    }
}