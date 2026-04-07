using StudentCourseSystem.Data;
using StudentCourseSystem.Models;
using Dapper;
namespace StudentCourseSystem.Repository
{
    public class StudentRepository:IStudentRepository
    {
        private readonly DapperContext _context;
        public StudentRepository(DapperContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Student>>Getswc()
        {
            var query = @"SELECT s.StudentId, s.StudentName, s.CourseId,
                             c.CourseId, c.CourseName
                      FROM Students s
                      INNER JOIN Courses c ON s.CourseId = c.CourseId";

            using (var connection = _context.CreateConnection())
            {
                var result = await connection.QueryAsync<Student, Course, Student>(
                    query,
                    (student, course) =>
                    {
                        student.course = course;
                        return student;
                    },
                    splitOn: "CourseId"
                );

                return result;
            }
        }
        public async Task<IEnumerable<Course>>Getcws()
        {
            var query = @"SELECT c.CourseId, c.CourseName,
                             s.StudentId, s.StudentName, s.CourseId
                      FROM Courses c
                      LEFT JOIN Students s ON c.CourseId = s.CourseId";

            using (var connection = _context.CreateConnection())
            {
                var courseDict = new Dictionary<int, Course>();

                var result = await connection.QueryAsync<Course, Student, Course>(
                    query,
                    (course, student) =>
                    {
                        if (!courseDict.TryGetValue(course.CourseId, out var currentCourse))
                        {
                            currentCourse = course;
                            currentCourse.Students = new List<Student>();
                            courseDict.Add(currentCourse.CourseId, currentCourse);
                        }

                        if (student != null)
                            currentCourse.Students.Add(student);

                        return currentCourse;
                    },
                    splitOn: "StudentId"
                );

                return courseDict.Values;
            }
        }
    }
}
