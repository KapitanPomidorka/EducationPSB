using Learning.Models;

namespace Learning.data.IRep
{
    public interface IHomeworkRep
    {
        IQueryable<Homework> GetAll();
        Task<Homework?> GetById(Guid Id);
        Task CreateAsync(Homework entity);
        Task UpdateAsync(Homework entity);
        Task DeleteAsync(Homework entity);
    }
}
