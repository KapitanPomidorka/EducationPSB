using Learning.data;
using Microsoft.EntityFrameworkCore;
using Learning.Shared.Models;

namespace Learning.Rep
{
    public class HomeworkRep
    {
        private readonly LearningDBContext _context;

        public HomeworkRep(LearningDBContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Homework entity)
        {
            await _context.Homeworks.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Homework entity)
        {
            _context.Homeworks.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public IQueryable<Homework> GetAll()
        {
            return _context.Homeworks.AsNoTracking();
        }

        public async Task<Homework?> GetById(Guid Id)
        {
            return await _context.Homeworks.FirstOrDefaultAsync(d => d.Id == Id);
        }

        public async Task UpdateAsync(Homework entity)
        {
            _context.Homeworks.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
