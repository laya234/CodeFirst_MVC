using Microsoft.EntityFrameworkCore;

namespace excf.Models
{
    public class PetContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }
        public PetContext(DbContextOptions<PetContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=localhost;database=pet;integrated security=true;trustservercertificate=true;");
        }
    }
}
