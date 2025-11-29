using Learning.Models;
using Learning.data;
using Microsoft.EntityFrameworkCore;

namespace Learning.Shared.Rep
{
    public class StudentRep
    {
        private readonly LearningDBContext _context;
        public StudentRep(LearningDBContext context)
        {
            _context = context;
        }
        public Task Authentication(StudentEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task<StudentEntity?> GetById(Guid Id)
        {
            return await _context.Students.FirstOrDefaultAsync(d => d.Id == Id);
        }

        public Task Logout(StudentEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
