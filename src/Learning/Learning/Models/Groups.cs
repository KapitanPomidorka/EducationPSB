namespace Learning.Models
{
    public class Groups
    {
        public Guid Id { get; set; }
        public string Group { get; set; } = null!;

        public List<StudentEntity> Students { get; set; } = [];
        public List<Homework> Homeworks { get; set; } = [];

    }
}
