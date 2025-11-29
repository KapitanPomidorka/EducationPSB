using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Learning.data.Configurations
{
    public class ProgressConf : IEntityTypeConfiguration<Progress>
    {
        public void Configure(EntityTypeBuilder<Models.Progress> builder)
        {


            builder.Property(n => n.FIO).IsRequired();
            builder.Property(n => n.Login).IsRequired();
            builder.Property(n => n.Password).IsRequired();
            builder.Property(n => n.Group).IsRequired();
            builder.Property(n => n.Role).IsRequired();

            builder.HasOne(g => g.Group).WithMany(s => s.Students);
        }
    }
}
