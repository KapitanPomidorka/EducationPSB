using Learning.Shared.DTO;

namespace Learning.Shared.IRep
{
    public interface IHomeworkRep
    {
        IQueryable<HomeworkDto> GetAll();
        Task<HomeworkDto?> GetById(Guid Id);
        Task CreateAsync(CreateHomeworkDto entity);
        Task UpdateAsync(UpdateHomeworkDto entity);
        Task DeleteAsync(HomeworkDto entity);
    }
}
