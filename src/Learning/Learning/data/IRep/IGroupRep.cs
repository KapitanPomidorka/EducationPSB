using Learning.Models;

namespace Learning.data.IRep
{
    public interface IGroupRep
    {
        IQueryable<Groups> GetAll();
        Task<Groups?> GetById(Guid Id);
        Task CreateAsync(Groups entity);
        Task UpdateAsync(Groups entity);
        Task DeleteAsync(Groups entity);
    }
}
