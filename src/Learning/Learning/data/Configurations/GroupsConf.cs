using Learning.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Learning.data.Configurations
{
    public class GroupsConf : IEntityTypeConfiguration<Groups>
    {
        public void Configure(EntityTypeBuilder<Groups> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(c => c.Group).IsRequired();

            builder.HasMany(s => s.Students).WithOne(s => s.Group);
            builder.HasMany(s => s.Homeworks).WithOne(s => s.Group);
        }
    }
}
