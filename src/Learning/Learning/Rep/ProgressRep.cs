using Learning.data;
using Microsoft.EntityFrameworkCore;
using Learning.Shared.Models;

namespace Learning.Rep
{
    public class ProgressRep
    {
        private readonly LearningDBContext _context;

        public ProgressRep(LearningDBContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Progress entity)
        {
            await _context.Progresses.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Progress entity)
        {
            _context.Progresses.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public IQueryable<Progress> GetAll()
        {
            return _context.Progresses.AsNoTracking();
        }

        public async Task<Progress?> GetById(Guid Id)
        {
            return await _context.Progresses.FirstOrDefaultAsync(d => d.Id == Id);
        }

        public async Task UpdateAsync(Progress entity)
        {
            _context.Progresses.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
