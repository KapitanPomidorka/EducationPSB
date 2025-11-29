

using Learning.Shared.General;
using System.ComponentModel.DataAnnotations;

namespace Learning.Shared.DTO
{
    public record MaterialsDto
  (
         Guid Id,
         [Required]
         [StringLength(100)]
         string Title,
         string Description,
         [Required]
         MaterialType Type,
         [Required]
         Guid CourseId,
         [Required]
         CoursesDto Course
    );


    public record CreateMaterialDto
  (
         Guid Id,
         [Required]
         [StringLength(100)]
         string Title,
         string Description,
         [Required]
         MaterialType Type,
         [Required]
         Guid CourseId,
         [Required]
         CoursesDto Course
    );

    public record UpdateMaterialDto
(
     Guid Id,
     [Required]
         [StringLength(100)]
         string Title,
     string Description,
     [Required]
         MaterialType Type,
     [Required]
         Guid CourseId,
     [Required]
         CoursesDto Course
);

}



