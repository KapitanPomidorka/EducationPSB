using Learning.Models;

namespace Learning.data.IRep
{
    public interface IProgressRep
    {
        IQueryable<Progress> GetAll();
        Task<Progress?> GetById(Guid Id);
        Task CreateAsync(Progress entity);
        Task UpdateAsync(Progress entity);
        Task DeleteAsync(Progress entity);
    }
}
