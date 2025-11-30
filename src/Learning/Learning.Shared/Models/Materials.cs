using Learning.Shared.General;

namespace Learning.Shared.Models
{
    public class Materials
    {
        
            public Guid Id { get; set; }
            public string Title { get; set; } = null!;
            public string Description { get; set; } = null!;
            public MaterialType Type { get; set; }

            public Guid CourseId { get; set; }
            public Courses Course { get; set; } = null!;

        public Materials(string title, string description, MaterialType type, Guid courseId, Courses course)
        {
            Id = new Guid();
            Title = title;
            Description = description;
            Type = type;
            CourseId = courseId;
            Course = course;
        }
        public Materials()
        {
            
        }
    }
    }
