
using Learning.Shared.DTO;

namespace Learning.Shared.IRep
{
    public interface ICoursesRep
    {
        IQueryable<CoursesDto> GetAll();
        Task<CoursesDtoById?> GetById(Guid Id);
        Task CreateAsync(CreateCourseDto entity);
        Task UpdateAsync(UpdateCourseDto entity);
        Task DeleteAsync(CoursesDto entity);
    }
}
