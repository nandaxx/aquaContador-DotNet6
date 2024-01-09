using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace InfraData.Context
{
    public class ContextDb : DbContext
    {
        public ContextDb() { }
        public ContextDb(DbContextOptions<ContextDb> options) : base(options)
        { }

        public DbSet<Person> People { get; set; }

        public DbSet<Drink> Drinks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.ApplyConfigurationsFromAssembly(typeof(ContextDb).Assembly);
        }
    }
}
