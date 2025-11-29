using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Learning.Shared.DTO
{
    public record ProgressDto(
        Guid Id,
        Guid HomeworkId,
        Guid StudentId,
        float Grade,
        string HomeworkTitle,
        string StudentName,
        string CourseName,
        string HomeworkDescription,
        DateTime HomeworkLimit
    );

    public record CreateProgressDto(
        [Required] Guid HomeworkId,
        [Required] Guid StudentId,
        [Range(0, 100, ErrorMessage = "Оценка должна быть от 0 до 100")] float Grade
    );

    public record UpdateProgressDto(
        [Range(0, 100, ErrorMessage = "Оценка должна быть от 0 до 100")] float Grade
    );

    public record StudentProgressDto(
        Guid ProgressId,
        Guid HomeworkId,
        string HomeworkTitle,
        string HomeworkDescription,
        DateTime HomeworkLimit,
        string CourseName,
        float Grade
    );

    public record HomeworkProgressDto(
        Guid ProgressId,
        Guid StudentId,
        string StudentName,
        string StudentLogin,
        float Grade
    );
}
