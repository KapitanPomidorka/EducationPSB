using Learning.Models;
using Microsoft.EntityFrameworkCore;

namespace Learning.data.IRep
{
    public class StudentRep : IStudentRep
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
