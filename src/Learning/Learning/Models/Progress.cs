namespace Learning.Models
{
    public class Progress
    {
        public Guid Id { get; set; }
        public Guid HomeworkId { get; set; }

        public Homework Homework { get; set; } = null!;
        public Guid StudentId { get; set; }

        public StudentEntity Student { get; set; } = null!;

        public float Grade { get; set; }

    }
}
