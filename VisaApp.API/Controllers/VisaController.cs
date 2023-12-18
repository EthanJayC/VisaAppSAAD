using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using VisaApp.Application.Queries;
using VisaApp.Application.Queries.Handlers;
using VisaApp.Infrastructure.Repositories;

namespace VisaApp.API.Controllers;

[ApiController]
[Route("api/visas")]
public class VisaController : BaseController
{
    private readonly SearchVisasQueryHandler _searchHandler;
    private readonly VisaRepository _visaRepository;

    public VisaController(SearchVisasQueryHandler searchHandler, VisaRepository visaRepository)
    {
        _searchHandler = searchHandler;
        _visaRepository = visaRepository;
    }


    //This endpoint is for performing a search for visas, currently via the mock repository that would contain the correct info
    [HttpGet("search")]
    public IActionResult SearchVisas([FromQuery] string query)
    {
        // Call the search handler to perform the search
        var result = _searchHandler.Handle(new SearchVisasQuery { SearchQuery = query });

        // Return the result to the client
        return Ok(result);
    }

    //API endpoint is designed to pull the visa info from the selected visa (using the Guid) when
    // a user selects a specific visa
    [HttpGet("{id}")]
    public IActionResult ReadVisa(Guid id)
    {
        var visa = _visaRepository.GetVisaById(id);

        if (visa == null)
        {
            return NotFound(); // Return 404 if the visa is not found
        }

        return Ok(visa);
    }
}