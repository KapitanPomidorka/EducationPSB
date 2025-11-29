using Learning.data;
using Learning.Models;
using Learning.Shared.DTO;
using Learning.Shared.IRep;
using Learning.Shared.Rep;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Learning.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoursesController : ControllerBase
    {
        private readonly CoursesRep _rep;
        private readonly MaterialsRep _materialsRep;

        public CoursesController(CoursesRep rep, MaterialsRep materialsRep)
        {
            _rep = rep;
            _materialsRep = materialsRep;
        }

        // GET: api/courses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CoursesDto>>> GetCourses()
        {
            var courses = _rep.GetAll();
            return Ok(courses);
        }

        // GET: api/courses/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<CoursesDtoById>> GetCourseById(Guid id)
        {
            var course = await _rep.GetById(id);

            if (course == null)
            {
                return NotFound($"Курс не найден");
            }

            return Ok(course);
        }

        // POST: api/courses
        [HttpPost]
        [Authorize(Roles = "Teacher,Admin")]
        public async Task<ActionResult<CoursesDto>> CreateCourse(CreateCourseDto createCourseDto) ///исправить!!!!
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdCourse = new Courses(createCourseDto.Title, createCourseDto.Description, _materialsRep.GetAll()
                .Where(c => c.CourseId == createCourseDto.Id).Select(m => new Materials
                (
                    m.Title, m.Description, m.Type, m.CourseId, m.Course

                    )).ToList());

            await _rep.CreateAsync(createdCourse);

            return Ok(createdCourse);
        }

        // PUT: api/courses/{id}
        [HttpPut("{id}")]
        [Authorize(Roles = "Teacher,Admin")]
        public async Task<IActionResult> UpdateCourse(UpdateCourseDto updateCourseDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var course = await _rep.GetById(updateCourseDto.Id);
            if (course == null)
            {
                return NotFound("Курс не найден");
            }
            await _rep.UpdateAsync(course);
            return NoContent();
        }

        // DELETE: api/courses/{id}
        [HttpDelete("{id}")]
        [Authorize(Roles = "Teacher,Admin")]
        public async Task<IActionResult> DeleteCourse(Guid id)
        {
            Courses? entity = await _rep.GetById(id);

            if (entity == null)
            {
                return NotFound("Курс не найден");
            }
            await _rep.DeleteAsync(entity);
            return NoContent();
        }

    }
}
    

