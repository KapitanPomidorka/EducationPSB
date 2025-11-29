using Learning.Shared.General;
using System.ComponentModel.DataAnnotations;


namespace Learning.Shared.DTO
{
    public record StudentDto(
        Guid Id,
        string FIO,
        Guid GroupId,
        Role Role,
        List<ProgressDto> Progresses
    );

    public record CreateStudentDto(
        [Required][StringLength(100)] string FIO,
        [Required] Guid GroupId,
        [Required][StringLength(50)] string Login,
        [Required][StringLength(100)] string Password,
        [Required] Role Role
    );

    public record UpdateStudentDto(
        [Required][StringLength(100)] string FIO,
        [Required] Guid GroupId,
        [Required][StringLength(50)] string Login,
        Role Role
    );

    public record LoginStudentDto(
        [Required] string Login,
        [Required] string Password
    );

    public record StudentAuthResponse(
        Guid Id,
        string FIO,
        string Login,
        Role Role,
        Guid GroupId,
        string Token
    );
}
