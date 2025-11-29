

using Learning.Shared.DTO;

namespace Learning.Shared.IRep
{
    public interface IStudentRep
    {
        Task<StudentDto?> GetById(Guid Id);
        Task Authentication(StudentAuthResponse entity);
        Task Logout(StudentAuthResponse entity);
    }
}
