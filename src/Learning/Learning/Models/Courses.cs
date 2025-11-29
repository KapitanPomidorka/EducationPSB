namespace Learning.Models
{
    public class Courses
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;

        public List<Materials> Materials { get; set; } = null!;
    }
}
