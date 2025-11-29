
using System.ComponentModel.DataAnnotations;


namespace Learning.Shared.DTO
{
    public record GroupDto
    {
        public Guid Id { get; set; }
        public string Group { get; set; } = null!;
        public List<StudentDto> Students { get; set; } = [];
        public List<HomeworkDto> Homeworks { get; set; } = [];
    }


    public class CreateGroupDto
    {
        [Required]
        [StringLength(50, ErrorMessage = "Название группы не может превышать 50 символов")]
        public string Group { get; set; } = null!;
    }

    public class UpdateGroupDto
    {
        [Required]
        [StringLength(50, ErrorMessage = "Название группы не может превышать 50 символов")]
        public string Group { get; set; } = null!;
    }
}
