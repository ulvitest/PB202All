using Academy.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academy.Data.DataAccess.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.Property(g => g.No).IsRequired(true).HasMaxLength(10);
            builder.Property(g => g.Limit).IsRequired(true);
            builder.Property(g => g.CreatedDate).IsRequired(true).HasColumnType("DateTime");

        }
    }
}
