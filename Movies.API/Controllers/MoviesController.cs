using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Movies.Application.DTOs;
using Movies.Application.Interfaces;

namespace Movies.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovieDto>>> GetAll()
        {
            var movies = await _movieService.GetAllAsync();
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MovieDto>> GetById(int id)
        {
            var movie = await _movieService.GetByIdAsync(id);
            if (movie == null)
                return NotFound(new {message = "Movie não encontrado"});
            
            return Ok(movie);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<MovieDto>> Create([FromBody] CreateMovieDto dto)
        {
            var movie = await _movieService.CreateAsync(dto);

            return CreatedAtAction(nameof(GetById), new { id = movie.Id }, movie);
        }

        [HttpDelete]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleted = await _movieService.DeleteAsync(id);

            if(!deleted)
                return NotFound(new {message = "Movie não encontrado"});

            return NoContent();
        }
    }
}
