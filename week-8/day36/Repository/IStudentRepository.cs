using StudentCourseSystem.Models;
namespace StudentCourseSystem.Repository
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> Getswc();
        Task<IEnumerable<Course>> Getcws();

    }
}
