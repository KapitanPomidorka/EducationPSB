using Learning.data;
using Microsoft.EntityFrameworkCore;
using Learning.Shared.Models;

namespace Learning.Rep
{
    public class GroupRep 
    {
        private readonly LearningDBContext _context;

        public GroupRep(LearningDBContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Groups entity)
        {
            await _context.Groups.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Groups entity)
        {
            _context.Groups.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public IQueryable<Groups> GetAll()
        {
            return _context.Groups.AsNoTracking();
        }

        public async Task<Groups?> GetById(Guid Id)
        {
            return await _context.Groups.Include(s=>s.Students).FirstOrDefaultAsync(d => d.Id == Id);
        }

        public async Task UpdateAsync(Groups entity)
        {
            _context.Groups.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
