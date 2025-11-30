namespace Learning.Shared.Models
{
    public class Homework
    {
        public Guid Id { get; set; }

        public Guid CurseId { get; set; }
        public Courses Course { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Description { get; set; } = string.Empty;

        public DateTime Limit {  get; set; }

        public Groups Group { get; set; } = null!;

        public Guid GroupId {  get; set; }

        public List<Progress> Progresses { get; set; } = null!;

        public Homework(Guid curseId, Courses course, string title, string description, DateTime limit, Groups group, Guid groupId)
        {
            Id = new Guid();
            CurseId = curseId;
            Course = course;
            Title = title;
            Description = description;
            Limit = limit;
            Group = group;
            GroupId = groupId;
        }
        public Homework()
        {
            
        }
    }


}
