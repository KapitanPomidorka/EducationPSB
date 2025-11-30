namespace Learning.Shared.Models
{
    public class Courses
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;

        public List<Materials> Materials { get; set; } = [];

        public Courses(string title, string description, List<Materials> materials)
        {
            Id = new Guid();
            Title = title;
            Description = description;
            Materials = materials;
        }
        public Courses()
        {
            
        }
    }
}
