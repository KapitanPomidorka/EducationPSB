using Learning.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Learning.data.Configurations
{
    public class StudentConf : IEntityTypeConfiguration<StudentEntity>
    {
        public void Configure(EntityTypeBuilder<StudentEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(n => n.FIO).IsRequired();
            builder.Property(n => n.Login).IsRequired();
            builder.Property(n => n.Password).IsRequired();
            builder.Property(n => n.Role).IsRequired();


            builder.HasOne(g => g.Group).WithMany(s => s.Students).HasForeignKey(g => g.GroupId);
        }
    }
}
