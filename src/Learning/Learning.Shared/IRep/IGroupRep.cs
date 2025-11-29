

using Learning.Shared.DTO;

namespace Learning.Shared.IRep
{
    public interface IGroupRep
    {
        IQueryable<GroupDto> GetAll();
        Task<GroupDto?> GetById(Guid Id);
        Task CreateAsync(CreateGroupDto entity);
        Task UpdateAsync(UpdateGroupDto entity);
        Task DeleteAsync(GroupDto entity);
    }
}
