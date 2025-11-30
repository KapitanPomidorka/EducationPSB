using Learning.Shared.General;

namespace Learning.Shared.Models
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

        public StudentEntity(string fio, Groups group, Guid groupId, string login, string password, List<Progress> progresses)
        {
            Id = new Guid();
            FIO = fio;
            Group = group;
            GroupId = groupId;
            Login = login;
            Password = password;
            Progresses = progresses;
        }
        public StudentEntity()
        {
            
        }

    }


}
