using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System.Linq;
using WebApplication1_Angular_HttpCLient.Contexts;
using WebApplication1_Angular_HttpCLient.Models;

namespace WebApplication1_Angular_HttpCLient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly MyDbContext dbContext;
        public StudentsController(MyDbContext _context) 
        {
            dbContext = _context;
        }

        // GET: api/Students
        [HttpGet("GetAllStudents")] //[Route("api/StudentsController/getStudents")]
        public async Task<IActionResult> GetAllStudents()
        {
            var studsList = await dbContext.students.ToListAsync();
            return Ok(studsList);
        }

        // GET: api/Students/5
        [HttpGet("GetStudent/{id}")]
        public async Task<IActionResult> GetStudent(int id)
        {
            var student = await dbContext.students.FirstOrDefaultAsync(s => s.id == id);
            if(student == null)
            {
                return NotFound($"Student with id {id} not found.");
            }
            return Ok(student);
        }

        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("SaveStudent")]
        public async Task<IActionResult> SaveStudent([FromBody] Student stud)
        {
            if(stud == null)
            {
                return BadRequest("Invalid student data.");
            }

            await dbContext.students.AddAsync(stud);
            await dbContext.SaveChangesAsync();
            //return CreatedAtAction(nameof(GetStudent), new { id = stud.id }, stud);
            return Ok();
        }

        // PUT: api/Students/4
        [HttpPut("UpdateStudent/{id}")]
        public async Task<IActionResult> UpdateStudent(int id, [FromBody] Student stud)
        {
            if (id != stud.id)
            {
                return BadRequest("Id in URL does not match id in the body.");
            }

            var student = await dbContext.students.FirstOrDefaultAsync(s => s.id == id);
            if(student == null)
            {
                return NotFound($"Student with id {id} not found.");
            }

            student.name = stud.name;
            student.progress = stud.progress;
            student.gender = stud.gender;
            student.rating = stud.rating;
            student.col = stud.col;
            student.dob = stud.dob;
            student.car = stud.car;

            dbContext.Entry(student).State = EntityState.Modified;//This explicitly tells Entity Framework that the existing object (existingStudent) is being updated.
            await dbContext.SaveChangesAsync();

            return NoContent();
        }

        //DELETE: api/Students/1
        [HttpDelete("DeleteStudent/{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var student = await dbContext.students.FirstOrDefaultAsync(s => s.id == id);
            if(student == null)
            {
                return NotFound($"Student with id {id} not found.");
            }

            dbContext.students.Remove(student);
            await dbContext.SaveChangesAsync();

            return NoContent();
        }

    }
}
