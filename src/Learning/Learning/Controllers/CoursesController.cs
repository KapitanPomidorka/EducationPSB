using Learning.data.IRep;
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
        public async Task<ActionResult<List<CourseDto>>> GetCourses()
        {
            try
            {
                var courses = await _courseRepository.GetAll()
                    .Select(c => new CourseDto
                    {
                        Id = c.Id,
                        Title = c.Title,
                        Description = c.Description,
                        MaterialsCount = c.Materials.Count
                    })
                    .ToListAsync();

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
        public async Task<ActionResult<CourseDetailDto>> GetCourse(Guid id)
        {
            try
            {
                var course = await _courseRepository.GetByIdWithMaterials(id);

                if (course == null)
                {
                    return NotFound($"Курс с ID {id} не найден");
                }

                var courseDto = new CourseDetailDto
                {
                    Id = course.Id,
                    Title = course.Title,
                    Description = course.Description,
                    Materials = course.Materials
                        .OrderBy(m => m.Order)
                        .Select(m => new MaterialDto
                        {
                            Id = m.Id,
                            Title = m.Title,
                            Content = m.Content,
                            Type = m.Type,
                            Order = m.Order,
                            CourseId = m.CourseId
                        })
                        .ToList()
                };

                return Ok(courseDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при получении курса {CourseId}", id);
                return StatusCode(500, "Произошла ошибка при получении данных");
            }
        }

        // POST: api/courses
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CourseDto>> CreateCourse(CreateCourseDto createDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var course = new Course
                {
                    Id = Guid.NewGuid(),
                    Title = createDto.Title,
                    Description = createDto.Description,
                    Materials = new List<Material>()
                };

                await _courseRepository.CreateAsync(course);

                var courseDto = new CourseDto
                {
                    Id = course.Id,
                    Title = course.Title,
                    Description = course.Description,
                    MaterialsCount = 0
                };

                return CreatedAtAction(nameof(GetCourse), new { id = course.Id }, courseDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при создании курса");
                return StatusCode(500, "Произошла ошибка при создании курса");
            }
        }

        // PUT: api/courses/{id}
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CourseDto>> UpdateCourse(Guid id, UpdateCourseDto updateDto)
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
                    return NotFound($"Курс с ID {id} не найден");
                }

                existingCourse.Title = updateDto.Title;
                existingCourse.Description = updateDto.Description;

                await _courseRepository.UpdateAsync(existingCourse);

                var courseDto = new CourseDto
                {
                    Id = existingCourse.Id,
                    Title = existingCourse.Title,
                    Description = existingCourse.Description,
                    MaterialsCount = existingCourse.Materials.Count
                };

                return Ok(courseDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при обновлении курса {CourseId}", id);
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
                    return NotFound($"Курс с ID {id} не найден");
                }

                await _courseRepository.DeleteAsync(course);

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при удалении курса {CourseId}", id);
                return StatusCode(500, "Произошла ошибка при удалении курса");
            }
        }

        // POST: api/courses/{courseId}/materials
        [HttpPost("{courseId}/materials")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<MaterialDto>> AddMaterial(Guid courseId, CreateMaterialDto createDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var course = await _courseRepository.GetById(courseId);
                if (course == null)
                {
                    return NotFound($"Курс с ID {courseId} не найден");
                }

                var material = new Material
                {
                    Id = Guid.NewGuid(),
                    Title = createDto.Title,
                    Content = createDto.Content,
                    Type = createDto.Type,
                    Order = createDto.Order,
                    CourseId = courseId
                };

                await _courseRepository.AddMaterialAsync(material);

                var materialDto = new MaterialDto
                {
                    Id = material.Id,
                    Title = material.Title,
                    Content = material.Content,
                    Type = material.Type,
                    Order = material.Order,
                    CourseId = material.CourseId
                };

                return CreatedAtAction(nameof(GetCourse), new { id = courseId }, materialDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ошибка при добавлении материала к курсу {CourseId}", courseId);
                return StatusCode(500, "Произошла ошибка при добавлении материала");
            }
        }
    
}
    }

