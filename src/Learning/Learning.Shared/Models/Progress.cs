namespace Learning.Shared.Models
{
    public class Progress
    {
        public Guid Id { get; set; }
        public Guid HomeworkId { get; set; }

        public Homework Homework { get; set; } = null!;
        public Guid StudentId { get; set; }

        public StudentEntity Student { get; set; } = null!;

        public float Grade { get; set; }
        public Progress()
        {
            
        }

        public Progress(Guid homeworkId, Homework homework, Guid studentId, StudentEntity student, float grade)
        {
            Id = Guid.NewGuid();
            HomeworkId = homeworkId;
            Homework = homework;
            Student = student;
            StudentId = studentId;
            Grade = grade;
        }
    }
}
