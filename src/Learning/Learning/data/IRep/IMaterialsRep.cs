using Learning.Models;

namespace Learning.data.IRep
{
    public interface IMaterialsRep
    {
        IQueryable<Materials> GetAll();
        Task<Materials?> GetById(Guid Id);
        Task CreateAsync(Materials entity);
        Task UpdateAsync(Materials entity);
        Task DeleteAsync(Materials entity);
    }
}
