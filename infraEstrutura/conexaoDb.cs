using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Model;

namespace PrimeiraAPI.infraEstrutura
{
    public class conexaoDb : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(
               "Server=localhost;" + 
                "Port=5432;Database=webAPI;"+
                "User Id=postgres;"+
                "Password=123;");
        
    }
}
