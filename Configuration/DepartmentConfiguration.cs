
using ComputersDB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComputersDB.Configuration
{

    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(d => d.Id);

            builder.HasMany(d => d.offices)
            .WithOne(o => o.department);

            builder.HasMany(d => d.Users)
            .WithOne(u => u.department)
            .HasForeignKey(d=>d.ComputerId);
        }
    }
}