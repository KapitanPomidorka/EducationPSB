using Learning.Models;

namespace Learning.data.IRep
{
    public interface IMaterials
    {
        IQueryable<Courses> GetAll();
        Task<Courses?> GetById(Guid Id);
        Task CreateAsync(Courses entity);
        Task UpdateAsync(Courses entity);
        Task DeleteAsync(Courses entity);
    }
}
