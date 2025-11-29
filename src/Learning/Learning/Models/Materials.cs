using Learning.Client.Models;

namespace Learning.Models
{
    public class Materials
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;

        public MaterialType Type { get; set; }

        public int? ScormCourseId { get; set; }
        //public ScormCourse ScormCourse { get; set; }

        public string FilePath { get; set; } = null!;     
        public string VideoUrl { get; set; }   = string.Empty;
        public string Content { get; set; } = string.Empty;   

        public Guid CourseId { get; set; }
        public Courses Course { get; set; } = null!;
    }

    public enum MaterialType
    {
        Text,
        Pdf,           
        Video,         
        Link,         
        Homework,       
        ScormPackage    
    }
}
