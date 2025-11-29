namespace Learning.Models
{
    public class StudentEntity
    {
        public Guid Id { get; set; }
        public string FIO { get; set; } = null!;
        public Groups Group { get; set; } = null!;

        public Guid GroupId { get; set; }

        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public Role Role { get; set; }

        public List<Progress> Progresses { get; set; } = null!;

    }

    public enum Role
    {
        Student,
        Teacher
    }
}
