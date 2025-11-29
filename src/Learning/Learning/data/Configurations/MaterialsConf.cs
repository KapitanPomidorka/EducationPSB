using Learning.Client.Models;
using Learning.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Learning.data.Configurations
{
    public class MaterialsConf : IEntityTypeConfiguration<Materials>
    {
        public void Configure(EntityTypeBuilder<Materials> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(c => c.Title).IsRequired();
            builder.Property(c => c.Description).IsRequired();
            builder.Property(c => c.Type).IsRequired();
            builder.Property(c => c.ScormCourseId).IsRequired();
            builder.Property(c => c.ScormCourse).IsRequired();
            builder.Property(c => c.FilePath).IsRequired();
            builder.Property(c => c.VideoUrl);
            builder.Property(c => c.Content);

            builder.HasOne(c => c.Course).WithMany(d => d.Materials).HasForeignKey(k => k.CourseId);


        }
    }
}
