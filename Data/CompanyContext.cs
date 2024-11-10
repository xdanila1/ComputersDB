using ComputersDB.Configuration;
using ComputersDB.Models;

using Microsoft.EntityFrameworkCore;

namespace ComputersDB.Data
{

    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options)
        : base(options)
        {
        }
        /*
        DbSet<Computer> Computers => Set<Computer>();
        DbSet<Department> departments => Set<Department>();
        DbSet<Office> offices => Set<Office>();
        DbSet<User> users => Set<User>();
        */

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration( new ComputerConfiguration());
            modelBuilder.ApplyConfiguration( new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration( new OfficeConfiguration());
            modelBuilder.ApplyConfiguration( new UserConfiguration());
        }
    }
}