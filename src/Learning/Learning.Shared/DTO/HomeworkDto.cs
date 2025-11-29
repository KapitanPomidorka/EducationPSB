using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Learning.Shared.DTO
{
    public record HomeworkDto(
        Guid Id,
        Guid CourseId,
        string Title,
        string Description,
        DateTime Limit,
        Guid GroupId,
        string CourseTitle,
        string GroupName,
        List<ProgressDto> Progresses
    );

    public record CreateHomeworkDto(
        [Required] Guid CourseId,
        [Required] Guid GroupId,
        [Required][StringLength(100)] string Title,
        [StringLength(1000)] string Description,
        [Required] DateTime Limit
    );

    public record UpdateHomeworkDto(
        [Required][StringLength(100)] string Title,
        [StringLength(1000)] string Description,
        [Required] DateTime Limit
    );
}
