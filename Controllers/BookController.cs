using Gestao_de_Livraria.Communication.Request;
using Gestao_de_Livraria.Communication.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gestao_de_Livraria.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterBookJson), StatusCodes.Status201Created)]
    public ActionResult Create([FromBody] RequestRegisterBookJson request)
    {
        var response = new ResponseRegisterBookJson
        {
            Id =1,
            Author = request.Author,
            BookGenre = request.BookGenre,
            Price = request.Price,
            StockQuantity = request.StockQuantity,
        };

        return Created(string.Empty, response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
    public ActionResult GetAll() {
        var response = new List<Book>()
        {
            new Book
            {
                Id =1,
                Author = "Rui Costa",
                BookGenre = Genre.Horror,
                Price = 100,
                StockQuantity = 4,
            },
            new Book
            {
                Id =2,
                Author = "Rui Costa",
                BookGenre = Genre.Action,
                Price = 100,
                StockQuantity = 4,
            }
        };  
             
        return Ok(response);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public ActionResult UpdateBook([FromBody] RequestUpdateBookJson request)
    {
        return NoContent();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public ActionResult DeleteBook() {
        return NoContent();
    }
}
