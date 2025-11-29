
using System.ComponentModel.DataAnnotations;

namespace Learning.Shared.DTO
{
    public record CoursesDto(
        Guid Id,
        [Required] string Title,
        [Required] string Description 

    );

    public record CoursesDtoById(
         Guid Id ,
        [Required]string Title ,
        [Required]string Description,
        List<MaterialsDto> Materials
    );

    public record CreateCourseDto
    (
        Guid Id,
        [Required]
        [StringLength(100)]
        string Title,

        [Required]
        [StringLength(500)]
        string Description,
         List<MaterialsDto> Materials
    );

    public record UpdateCourseDto
      (
        [Required]
        Guid Id,
        [Required]
        [StringLength(100)]
        string Title,

        [Required]
        [StringLength(500)]
        string Description,
         List<MaterialsDto> Materials
    );
}
