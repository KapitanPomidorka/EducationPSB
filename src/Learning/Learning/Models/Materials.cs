

using Learning.Shared.General;

namespace Learning.Models
{
    public class Materials
    {
        
            public Guid Id { get; set; }
            public string Title { get; set; } = null!;
            public string Description { get; set; } = null!;
            public MaterialType Type { get; set; }

            public Guid CourseId { get; set; }
            public Courses Course { get; set; } = null!;
        }
    }
