using System.CodeDom;

namespace Learning.Shared.Models
{
    public class Groups
    {
        public Guid Id { get; set; }
        public string Group { get; set; } = null!;

        public List<StudentEntity> Students { get; set; } = [];
        public List<Homework> Homeworks { get; set; } = [];

        public Groups(string group, List<StudentEntity> students, List<Homework> homeworks)
        {
            Id = new Guid();
            Group = group;
            Students = students;
            Homeworks = homeworks;
        }
        public Groups()
        {
            
        }

    }
}
