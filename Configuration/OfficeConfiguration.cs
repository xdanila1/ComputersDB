
using ComputersDB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComputersDB.Configuration
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.HasKey(o => o.Id);

            builder.HasMany(o => o.Users)
            .WithOne(u => u.Office)
            .HasForeignKey(u => u.OfficeId);
        }
    }
}