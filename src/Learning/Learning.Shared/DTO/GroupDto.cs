
using System.ComponentModel.DataAnnotations;


namespace Learning.Shared.DTO
{
    public record GroupDto
    (
        Guid Id,
         string Group,
         List<StudentDto> Students,
         List<HomeworkDto> Homeworks 
        );



public record CreateGroupDto
(
    [Required]
        [StringLength(50, ErrorMessage = "Название группы не может превышать 50 символов")]
    string Group
);

    public record UpdateGroupDto
    (
        [Required]
        [StringLength(50, ErrorMessage = "Название группы не может превышать 50 символов")]
        string Group,
         List<StudentDto> Students,
         List<HomeworkDto> Homeworks
    );
}
