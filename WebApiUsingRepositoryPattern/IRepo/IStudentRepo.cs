using WebApi_Demo.Models;

namespace WebApiUsingRepositoryPattern.IRepo
{
    public interface IStudentRepo
    {
        public List<Student> GetStudents();
        public Student GetStudentById(int id);
        public Student AddStudent(Student student);
        public Student UpdateStudent(int id, Student student);
        public bool DeleteStudent(int id);
    }
}
