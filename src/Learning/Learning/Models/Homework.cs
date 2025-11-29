namespace Learning.Models
{
    public class Homework
    {
        public Guid Id { get; set; }

        public Guid CurseId { get; set; }
        public Courses Courses { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = string.Empty;

        public DateTime Limit {  get; set; }

        public Groups Group { get; set; } = null!;

        public Guid GroupId {  get; set; }

        public List<Progress> Progresses { get; set; } = null!;
    }
}
