using Learning.Models;

namespace Learning.data.IRep
{
    public interface IStudentRep
    {
        Task<StudentEntity?> GetById(Guid Id);
        Task Authentication(StudentEntity entity);
        Task Logout(StudentEntity entity);
    }
}
