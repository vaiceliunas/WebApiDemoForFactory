using Microsoft.EntityFrameworkCore;
using WebApiDemoForFactory.Models.Entities;

namespace WebApiDemoForFactory.Models.DbContexts
{
    public class PeopleDbContext : DbContext
    {
        public PeopleDbContext()
        {
        }

        public PeopleDbContext(DbContextOptions<PeopleDbContext> options) : base(options)
        {
        }
        public DbSet<Person> Persons{ get; set; }
        public DbSet<StdProperty> StdProperties { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer();
        //}
    }
}
