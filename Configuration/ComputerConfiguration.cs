

using ComputersDB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComputersDB.Configuration
{
    public class ComputerConfiguration : IEntityTypeConfiguration<Computer>
    {
        public void Configure(EntityTypeBuilder<Computer> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasOne(c => c.User)
            .WithMany(u => u.Computers)
            .HasForeignKey(c => c.UserId);
        }
    }
}