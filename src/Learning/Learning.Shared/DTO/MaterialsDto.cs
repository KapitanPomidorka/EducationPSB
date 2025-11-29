

using Learning.Shared.General;
using System.ComponentModel.DataAnnotations;

namespace Learning.Shared.DTO
{
    public record MaterialsDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public MaterialType Type { get; set; }

        public Guid CourseId { get; set; }
        public CoursesDto Course { get; set; } = null!;
    }


    public record CreateMaterialDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public MaterialType Type { get; set; }

        public Guid CourseId { get; set; }
        public CoursesDto Course { get; set; } = null!;
    }

}



