using Learning.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Learning.data.Configurations
{
    public class HomeworkConf : IEntityTypeConfiguration<Homework>
    {
        public void Configure(EntityTypeBuilder<Homework> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(c=>c.CurseId).IsRequired();
            builder.Property(c=>c.Title).IsRequired();
            builder.Property(c=>c.Description);
            builder.Property(c=>c.Limit).IsRequired();
            builder.Property(c=>c.CurseId).IsRequired();
            builder.Property(c=>c.GroupId).IsRequired();

            builder.HasOne(c=>c.Group).WithMany(d=>d.Homeworks).HasForeignKey(d=>d.GroupId); 


        }
    }
}
