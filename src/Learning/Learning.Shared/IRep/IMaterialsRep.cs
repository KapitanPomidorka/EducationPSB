

using Learning.Shared.DTO;

namespace Learning.Shared.IRep
{
    public interface IMaterialsRep
    {
        IQueryable<MaterialsDto> GetAll();
        Task<MaterialsDto?> GetById(Guid Id);
        Task CreateAsync(CreateMaterialDto entity);
        Task UpdateAsync(UpdateMaterialDto entity);
        Task DeleteAsync(MaterialsDto entity);
    }
}
