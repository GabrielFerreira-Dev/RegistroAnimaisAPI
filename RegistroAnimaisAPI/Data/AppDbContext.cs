using Microsoft.EntityFrameworkCore;
using RegistroAnimaisAPI.Models;

namespace RegistroAnimaisAPI.Data {
    public class AppDbContext : DbContext{
    
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 
            
        }

        public DbSet<Animal> Animal { get; set; }
    }
}
