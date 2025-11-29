

using System.ComponentModel.DataAnnotations;

namespace Learning.Shared.DTO
{
    public record MaterialDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public MaterialType Type { get; set; }

        public Guid CourseId { get; set; }
        public CoursesDto Course { get; set; } = null!;
    }

    public enum MaterialType
    {
        Text,
        Pdf,
        Video,
        Link,
        Scorm
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

}

