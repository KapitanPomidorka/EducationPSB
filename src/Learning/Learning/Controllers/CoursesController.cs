using Learning.data.IRep;
using Learning.Models;
using Learning.Shared.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Learning.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class CoursesController : ControllerBase
    {
        private readonly ICoursesRep _courseRepository;

        public CoursesController(
            ICoursesRep courseRepository)
        {
            _courseRepository = courseRepository;
        }

        // GET: api/courses
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<CoursesDto>>> GetCourses()
        {
            try
            {
                var courses = _courseRepository.GetAll()
                    .Select(c => new CoursesDto
                    {
                        Id = c.Id,
                        Title = c.Title,
                        Description = c.Description,
                    }).ToList();


                return Ok(courses);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Произошла ошибка при получении данных");
            }
        }

        // GET: api/courses/{id}
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CoursesDto>> GetCourse(Guid id)
        {
            try
            {
                var course = await _courseRepository.GetById(id);

                if (course == null)
                {
                    return NotFound("Курс не найден");
                }

                var courseDto = new CoursesDtoById
                {
                    Id = course.Id,
                    Title = course.Title,
                    Description = course.Description,
                    Materials = course.Materials
                        .OrderBy(m => m.Title)
                        .Select(m => new MaterialsDto
                        {
                            Id = m.Id,
                            Title = m.Title,
                            Description = m.Description,
                            Type = m.Type,
                            CourseId = m.CourseId
                        })
                        .ToList()
                };

                return Ok(courseDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Произошла ошибка при получении данных");
            }
        }

        // POST: api/courses
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CoursesDto>> CreateCourse(CreateCourseDto createDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var course = new Courses
                {
                    Id = Guid.NewGuid(),
                    Title = createDto.Title,
                    Description = createDto.Description,
                    Materials = new List<Materials>()
                };

                await _courseRepository.CreateAsync(course);
                return Ok(course);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Произошла ошибка при создании курса");
            }
        }

        // PUT: api/courses/{id}
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CoursesDto>> UpdateCourse(Guid id, UpdateCourseDto updateDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var existingCourse = await _courseRepository.GetById(id);
                if (existingCourse == null)
                {
                    return NotFound("Курс не найден");
                }

                existingCourse.Title = updateDto.Title;
                existingCourse.Description = updateDto.Description;

                await _courseRepository.UpdateAsync(existingCourse);

                var courseDto = new CoursesDtoById
                {
                    Id = existingCourse.Id,
                    Title = existingCourse.Title,
                    Description = existingCourse.Description,
                    Materials = new List<MaterialsDto>()

                };

                return Ok(courseDto);
            }
            catch (Exception ex)
            {

                return StatusCode(500, "Произошла ошибка при обновлении курса");
            }
        }

        // DELETE: api/courses/{id}
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteCourse(Guid id)
        {
            try
            {
                var course = await _courseRepository.GetById(id);
                if (course == null)
                {
                    return NotFound("Курс не найден");
                }

                await _courseRepository.DeleteAsync(course);

                return NoContent();
            }
            catch (Exception ex)
            {

                return StatusCode(500, "Произошла ошибка при удалении курса");
            }
        }

       }
    }

