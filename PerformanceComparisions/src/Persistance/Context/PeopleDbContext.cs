using Domain.RegularEntities;
using Microsoft.EntityFrameworkCore;

namespace Persistance.Context
{
    public class PeopleDbContext : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public PeopleDbContext(DbContextOptions options)
             : base(options)
        {
        }

        public DbSet<Person> People { get; protected set; }
        public DbSet<Address> Addresses { get; protected set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PeopleDbContext).Assembly);
        }

    }
}
