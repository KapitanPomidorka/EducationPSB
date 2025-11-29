using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Learning.Shared.DTO
{
    public record ProgressDto(
       Guid Id ,
     Guid HomeworkId ,
     HomeworkDto Homework,
    Guid StudentId ,
    StudentDto Student ,
    float Grade
    );

    public record CreateProgressDto(
        [Required] Guid HomeworkId,
        [Required] Guid StudentId,
        [Range(0, 100, ErrorMessage = "Оценка должна быть от 0 до 100")] float Grade
    );

    public record UpdateProgressDto(
        [Range(0, 100, ErrorMessage = "Оценка должна быть от 0 до 100")] float Grade
    );

}
