using Microsoft.EntityFrameworkCore;
using Veterinary.Shared.Entities;

namespace Veterinary.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions <DataContext> options): base(options) 
        { 
         
        }

        //Comienzo a registrar las entidades

        public DbSet<Owner> Owners { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }



    }
}
