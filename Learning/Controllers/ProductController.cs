using Learning.Models;
using Learning.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Learning.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IBookRepository _bookRepo;

        public ProductController(IBookRepository repo)
        {
            _bookRepo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBook()
        {
            try
            {
                return Ok(await _bookRepo.GetAllBookAsync());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<IActionResult> GetBookById(int id)
        {
            var book = await _bookRepo.GetBookAsync(id);
            return book == null ? NotFound() : Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewBook(BookModel book)
        {
            var id = await _bookRepo.AddBookAsync(book);
            return CreatedAtAction(nameof(GetBookById), new { id }, book);
        }

        [HttpPost("{id}")]
        public async Task<IActionResult> UpdateBook(int id, BookModel book)
        {
            try
            {
                if (id != book.Id)
                {
                    return BadRequest();
                }

                await _bookRepo.UpdateBookAsync(id, book);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return NoContent();
        }
    }
}
