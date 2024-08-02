using WebApi_Demo.Models;
using WebApi_EF.Context;
using WebApiUsingRepositoryPattern.IRepo;

namespace WebApiUsingRepositoryPattern.Repo
{
    public class StudentRepo : IStudentRepo
    {
        StudentDbContext _context;
        public StudentRepo(StudentDbContext context)
        {
            _context = context;
        }
        public Student AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        public bool DeleteStudent(int id)
        {
            var obj = _context.Students.FirstOrDefault(x => x.Id == id);
            if (obj != null)
            {
                _context.Students.Remove(obj);
                _context.SaveChanges();
            }

            return true;
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.FirstOrDefault(x => x.Id == id);
        }

        public List<Student> GetStudents()
        {
            return _context.Students.ToList();
        }

        public Student UpdateStudent(int id, Student student)
        {
            var obj = _context.Students.FirstOrDefault(x => x.Id == id);
            if (obj != null)
            {
                obj.Batch = student.Batch;
                _context.SaveChanges();
            }
            return obj;
        }
    }
}
