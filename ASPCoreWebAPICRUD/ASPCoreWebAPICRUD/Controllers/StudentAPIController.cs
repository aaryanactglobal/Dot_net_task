using ASPCoreWebAPICRUD.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPCoreWebAPICRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAPIController : ControllerBase
    {
        private readonly CodeApiContext context;

        public StudentAPIController(CodeApiContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task <ActionResult<List<Hotel>>> GetHotel()
        {
            var data= await context.Hotels.ToListAsync();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Hotel>>> GetHotelsById(int id)
        {
            var student = await context.Hotels.FindAsync(id);
            if(student == null)
            {
                return NotFound();
            }
            return Ok();
        }
        [HttpPost]
        public async Task<ActionResult<List<Hotel>>> CreateHotelsById(Hotel htd)
        {
            await context.Hotels.AddAsync(htd);
            await context.SaveChangesAsync();
            return Ok(htd);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<List<Hotel>>> UpdateHotelsById(int id,Hotel htd)
        {
            //if(id ! = htd.HotelId)
            //{
            //    return BadRequest();
            //}
            context.Entry(htd).State= EntityState.Modified;
            await context.SaveChangesAsync();
            return Ok(htd);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Hotel>>> DeleteHotel(int id)
        {
            var student = await context.Hotels.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            context.Hotels.Remove(student);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
