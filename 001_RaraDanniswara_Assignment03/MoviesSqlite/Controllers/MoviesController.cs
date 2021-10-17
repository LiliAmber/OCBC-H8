using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using MoviesSqlite.Data;
using MoviesSqlite.Models;

namespace MoviesSqlite.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesSqliteController : ControllerBase
    {
        
        private readonly ApiDbContext _context;

        public MoviesSqliteController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetMovies() 
        {
            var movies = await _context.Movies.ToListAsync();
            return Ok(movies);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie(MoviesData data) 
        {
            if(ModelState.IsValid) 
            {
                await _context.Movies.AddAsync(data);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetMovies", new {data.Id}, data);
            }

            return new JsonResult("Something went wrong") {StatusCode = 500};
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetMovies(int id) 
        {
            var movies = await _context.Movies.FirstOrDefaultAsync(x => x.Id == id);

            if(movies == null)
                return NotFound();
            return Ok(movies);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMovies(int id, MoviesData movies)
        {
            if(id != movies.Id)
                return BadRequest();
            
            var existMovies = await _context.Movies.FirstOrDefaultAsync(x => x.Id == id);

            if(existMovies == null)
                return NotFound();

            existMovies.Name = movies.Name;
            existMovies.Genre = movies.Genre;
            existMovies.Duration = movies.Duration;
            existMovies.ReleaseDate = movies.ReleaseDate;
            
            // Implement the changes on the database level
            await _context.SaveChangesAsync();

            // return NoContent();
            return Ok("success to update");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovies(int id)
        {
            var existMovies = await _context.Movies.FirstOrDefaultAsync(x => x.Id == id);

            if(existMovies == null)
                return NotFound();

            _context.Movies.Remove(existMovies);
            await _context.SaveChangesAsync();

            // return Ok(existMovies);//==respon disini==
            return Ok("success to delete");
        }
    }
}
