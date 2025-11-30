using Learning.data;
using Microsoft.EntityFrameworkCore;
using Learning.Shared.Models;

namespace Learning.Rep
{
    public class MaterialsRep
    {
        private readonly LearningDBContext _context;

        public MaterialsRep(LearningDBContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Materials entity)
        {
            await _context.Materials.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Materials entity)
        {
            _context.Materials.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public IQueryable<Materials> GetAll()
        {
            return _context.Materials.AsNoTracking();
        }

        public async Task<Materials?> GetById(Guid Id)
        {
            return await _context.Materials.FirstOrDefaultAsync(d => d.Id == Id);
        }

        public async Task UpdateAsync(Materials entity)
        {
            _context.Materials.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
