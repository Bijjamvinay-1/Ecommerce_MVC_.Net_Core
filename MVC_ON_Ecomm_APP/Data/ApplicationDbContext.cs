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
      
    }
}
