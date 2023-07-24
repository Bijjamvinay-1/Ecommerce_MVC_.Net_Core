using Microsoft.EntityFrameworkCore;
using MVC_ON_Ecomm_APP.Models;

namespace MVC_ON_Ecomm_APP.Data
{
    public class ApplicationDbContext : DbContext   
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        } 
        public DbSet<Category>Categories { get; set; }
        // here adding the data in category table to data base .by overiding the OnModelCreating method
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Scifi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                  
                );


                
        }
    }
}
