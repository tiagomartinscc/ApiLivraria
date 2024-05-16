using ApiLivraria.Comunications.Requests;
using ApiLivraria.Comunications.Responses;
using Microsoft.AspNetCore.Mvc;

namespace ApiLivraria.Controllers;

public class BookController : ApiLivrariaBaseController
{

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(BookResponse), StatusCodes.Status200OK)]
    public IActionResult GetById([FromRoute] int id)
    {
        var response = new BookResponse
        {
            Id = 1,
            Title = "A ilha misteriosa",
            Author = "Júlio Verne",
            Category = EnumCategory.Ficção.ToString(),
            Price = 37.93m,
            Quantity = 100
        };

        return Ok(response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<BookResponse>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new List<BookResponse>
        {
            new BookResponse
            { 
                Id = 1,
                Title = "A ilha misteriosa",
                Author = "Júlio Verne",
                Category = EnumCategory.Ficção.ToString(),
                Price = 37.93m,
                Quantity = 100
            }
        };

        return Ok(response);
    }

    [HttpPost]
    [ProducesResponseType(typeof(BookResponse), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] BookRequest request)
    {
        var response = new BookResponse
        {
            Id = 2,
            Title = request.Title,
            Author = request.Author,
            Category = request.Category,
            Price = request.Price,
            Quantity = request.Quantity
        };

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromRoute] int id, [FromBody] BookRequest request)
    {
        return NoContent();
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] int id)
    {
        return NoContent();
    }

}
