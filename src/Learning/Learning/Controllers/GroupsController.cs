using Learning.Models;
using Learning.Shared.DTO;
using Learning.Shared.IRep;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace Learning.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class GroupsController : ControllerBase
    {
        private readonly IGroupRep _groupRepository;

        public GroupsController(IGroupRep groupRepository)
        {
            _groupRepository = groupRepository;
        }

        // GET: api/groups
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<GroupDto>>> GetGroups()
        {
            var groups = await _groupRepository.GetAll()
                .Select(g => new GroupDto
                {
                    Id = g.Id,
                    Group = g.Group,
                    Students = g.Students
                    .OrderBy(m => m.FIO)
                    .Select(m => new StudentEntity()
                    {
                        Id = m.Id,
                        FIO = m.FIO,
                        Role = m.Role,

                        GroupId = m.GroupId
                    });
                    Homeworks = g.Homeworks.OrderBy(m => m.FIO)
                    .Select(m => new HomeworkDto
                    {
                        Id = m.Id,
                        Title = m.FIO,
                        Description = m.Description,
                        Type = m.Type,

                        CourseId = m.CourseId
                    }}
                    .ToList();


            return Ok(groups);
        }

        // GET: api/groups/{id}
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GroupDetailDto>> GetGroup(Guid id)
        {
            var group = await _groupRepository.GetByIdWithStudentsAndHomeworks(id);

            if (group == null)
            {
                return NotFound($"Группа с ID {id} не найдена");
            }

            var groupDto = new GroupDetailDto
            {
                Id = group.Id,
                Group = group.Group,
                Students = group.Students
                    .Select(s => new StudentDto
                    {
                        Id = s.Id,
                        FirstName = s.FirstName,
                        LastName = s.LastName,
                        Email = s.Email
                    })
                    .ToList(),
                Homeworks = group.Homeworks
                    .Select(h => new HomeworkDto
                    {
                        Id = h.Id,
                        Title = h.Title,
                        Description = h.Description,
                        Deadline = h.Deadline
                    })
                    .ToList()
            };

            return Ok(groupDto);
        }

        // GET: api/groups/{id}/students
        [HttpGet("{id}/students")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<StudentDto>>> GetGroupStudents(Guid id)
        {
            var group = await _groupRepository.GetByIdWithStudents(id);

            if (group == null)
            {
                return NotFound($"Группа с ID {id} не найдена");
            }

            var students = group.Students
                .Select(s => new StudentDto
                {
                    Id = s.Id,
                    FirstName = s.FirstName,
                    LastName = s.LastName,
                    Email = s.Email
                })
                .ToList();

            return Ok(students);
        }

        // GET: api/groups/{id}/homeworks
        [HttpGet("{id}/homeworks")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<HomeworkDto>>> GetGroupHomeworks(Guid id)
        {
            var group = await _groupRepository.GetByIdWithHomeworks(id);

            if (group == null)
            {
                return NotFound($"Группа с ID {id} не найдена");
            }

            var homeworks = group.Homeworks
                .Select(h => new HomeworkDto
                {
                    Id = h.Id,
                    Title = h.Title,
                    Description = h.Description,
                    Deadline = h.Deadline
                })
                .ToList();

            return Ok(homeworks);
        }

        // POST: api/groups
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<GroupDto>> CreateGroup(CreateGroupDto createDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Group Group = await _groupRepository.GetById(createDto.GroupId);
            if ()
            {
                ModelState.AddModelError(nameof(createDto.Group), "Группа с таким названием уже существует");
                return BadRequest(ModelState);
            }

            var group = new Group
            {
                Id = Guid.NewGuid(),
                Group = createDto.Group
            };

            await _groupRepository.CreateAsync(group);

            var groupDto = new GroupDto
            {
                Id = group.Id,
                Group = group.Group,
                StudentsCount = 0,
                HomeworksCount = 0
            };

            return CreatedAtAction(nameof(GetGroup), new { id = group.Id }, groupDto);
        }

        // PUT: api/groups/{id}
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GroupDto>> UpdateGroup(Guid id, UpdateGroupDto updateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingGroup = await _groupRepository.GetById(id);
            if (existingGroup == null)
            {
                return NotFound($"Группа с ID {id} не найдена");
            }

            // Проверка на уникальность названия группы (исключая текущую группу)
            if (await _groupRepository.GetAll()
                .AnyAsync(g => g.Group == updateDto.Group && g.Id != id))
            {
                ModelState.AddModelError(nameof(updateDto.Group), "Группа с таким названием уже существует");
                return BadRequest(ModelState);
            }

            existingGroup.Group = updateDto.Group;
            await _groupRepository.UpdateAsync(existingGroup);

            var groupDto = new GroupDto
            {
                Id = existingGroup.Id,
                Group = existingGroup.Group,
                StudentsCount = existingGroup.Students.Count,
                HomeworksCount = existingGroup.Homeworks.Count
            };

            return Ok(groupDto);
        }

        // DELETE: api/groups/{id}
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteGroup(Guid id)
        {
            var group = await _groupRepository.GetById(id);
            if (group == null)
            {
                return NotFound($"Группа с ID {id} не найдена");
            }

            await _groupRepository.DeleteAsync(group);

            return NoContent();
        }

        // GET: api/groups/search/{groupName}
        [HttpGet("search/{groupName}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<GroupDto>> GetGroupByName(string groupName)
        {
            var group = await _groupRepository.GetAll()
                .FirstOrDefaultAsync(g => g.Group == groupName);

            if (group == null)
            {
                return NotFound($"Группа с названием '{groupName}' не найдена");
            }

            var groupDto = new GroupDto
            {
                Id = group.Id,
                Group = group.Group,
                StudentsCount = group.Students.Count,
                HomeworksCount = group.Homeworks.Count
            };

            return Ok(groupDto);
        }
    }
}
