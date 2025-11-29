using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Learning.data.Configurations
{
    public class ProgressConf : IEntityTypeConfiguration<Models.Progress>
    {
        public void Configure(EntityTypeBuilder<Models.Progress> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(n => n.HomeworkId).IsRequired();
            builder.Property(n => n.StudentId).IsRequired();
            builder.Property(n => n.Grade);

            builder.HasOne(g => g.Homework).WithMany(s => s.Progresses);
            builder.HasOne(g => g.Student).WithMany(s => s.Progresses);
        }

    }
}
