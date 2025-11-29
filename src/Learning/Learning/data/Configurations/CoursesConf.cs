using Learning.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Learning.data.Configurations
{
    public class CoursesConf : IEntityTypeConfiguration<Courses>
    {
        public void Configure(EntityTypeBuilder<Courses> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(c => c.Title).IsRequired();
            builder.Property(c => c.Description).IsRequired();

            builder.HasMany(s => s.Materials).WithOne(s => s.Course);

        }
    }
}
