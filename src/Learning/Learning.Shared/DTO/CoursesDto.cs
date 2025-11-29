
using System.ComponentModel.DataAnnotations;

namespace Learning.Shared.DTO
{
    public record CourseDto
    {
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!;

        public List<MaterialsDto> Materials { get; set; } = [];
    }

    public record CreateCourseDto
    {
        [Required]
        [StringLength(100)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(500)]
        public string Description { get; set; } = null!;

        public List<MaterialsDto> Materials { get; set; } = [];
    }

    public record UpdateCourseDto
    {
        [Required]
        [StringLength(100)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(500)]
        public string Description { get; set; } = null!;

        public List<MaterialsDto> Materials { get; set; } = [];

    }
}
