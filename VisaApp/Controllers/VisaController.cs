using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using VisaApp.Application.Queries;
using VisaApp.Application.Queries.Handlers;

namespace VisaApp.API.Controllers;

[ApiController]
[Route("api/visas")]
public class VisaController : BaseController
{
    private readonly SearchVisasQueryHandler _searchHandler;

    public VisaController(SearchVisasQueryHandler searchHandler)
    {
        _searchHandler = searchHandler;
    }

    [HttpGet("search")]
    public IActionResult SearchVisas([FromQuery] string query)
    {
        // Call the search handler to perform the search
        var result = _searchHandler.Handle(new SearchVisasQuery { SearchQuery = query });

        // Return the result to the client
        return Ok(result);
    }
}