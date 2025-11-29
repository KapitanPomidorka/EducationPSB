namespace Learning.Models
{
    public class Courses
    {
        public Guid Id { get; set; }

        public string Course { get; set; } = null!;

        public List<Materials> Materials { get; set; } = null!;
    }
}
