using Learning.Models;
using Microsoft.EntityFrameworkCore;

namespace Learning.data.IRep
{
    public class CoursesRep : ICoursesRep
    {
        private readonly LearningDBContext _context;

        public CoursesRep(LearningDBContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Courses entity)
        {
            await _context.Courses.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Courses entity)
        {
            _context.Courses.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public IQueryable<Courses> GetAll()
        {
            return _context.Courses.AsNoTracking();
        }

        public async Task<Courses?> GetById(Guid Id)
        {
            return await _context.Courses.FirstOrDefaultAsync(d => d.Id == Id);
        }

        public async Task UpdateAsync(Courses entity)
        {
            _context.Courses.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
