namespace Learning.Models
{
    public class Materials
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public Guid CourseId { get; set; }

        public string Url { get; set; } = null!;

        public bool Watched { get; set; }
    }
}
