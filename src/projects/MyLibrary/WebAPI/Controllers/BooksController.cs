using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{

    [HttpGet]
    public async Task<IActionResult> Get()
    {

        using (BaseContext context=new BaseContext())
        {
            var result= await context.Books.ToListAsync();
            return Ok(result);
        }
        
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] Book book)
    {
        using(BaseContext context=new BaseContext())
        {
            await context.AddAsync(book);
            await context.SaveChangesAsync();

            return Ok(book);
        }
    }
}