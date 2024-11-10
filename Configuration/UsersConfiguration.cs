
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComputersDB.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.HasOne(u => u.Office)
            .WithMany(o => o.Users)
            .HasForeignKey(u => u.OfficeId);

            builder.HasOne(u => u.department)
            .WithMany(d => d.Users)
            .HasForeignKey(d => d.departmentId);
        }
    }
}