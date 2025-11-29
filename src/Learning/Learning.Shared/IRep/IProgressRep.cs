
using Learning.Shared.DTO;

namespace Learning.Shared.IRep
{
    public interface IProgressRep
    {
        IQueryable<ProgressDto> GetAll();
        Task<ProgressDto?> GetById(Guid Id);
        Task CreateAsync(CreateProgressDto entity);
        Task UpdateAsync(UpdateProgressDto entity);
        Task DeleteAsync(ProgressDto entity);
    }
}
