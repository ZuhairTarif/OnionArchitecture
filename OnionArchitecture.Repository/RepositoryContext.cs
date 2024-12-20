using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Entities.Models;

namespace OnionArchitecture.Repository
{
    public class RepositoryContext(DbContextOptions<RepositoryContext> options) : DbContext(options)
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }

}
