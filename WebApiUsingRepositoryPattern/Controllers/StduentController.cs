using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_Demo.Models;
using WebApiUsingRepositoryPattern.IRepo;

namespace WebApiUsingRepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StduentController : ControllerBase
    {
        IStudentRepo _repo; 
        public StduentController(IStudentRepo repo) {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return Ok(_repo.GetStudents());
        }
        [HttpGet("{id}")]
        public IActionResult Details(int id)
        {
            return Ok(_repo.GetStudentById(id));
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            var stuent = _repo.AddStudent(student);
            return Created("added", student);
        }

        public IActionResult Edit(int id, Student student)
        {
            _repo.UpdateStudent(id, student);
            return Ok();
        }

        public IActionResult Delete(int id) {   
            _repo.DeleteStudent(id);
            return Ok();
        }
    }
}
