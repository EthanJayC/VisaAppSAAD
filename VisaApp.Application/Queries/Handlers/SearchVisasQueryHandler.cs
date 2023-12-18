using VisaApp.Domain.Entities;
using VisaApp.Infrastructure.Repositories;

namespace VisaApp.Application.Queries.Handlers;

public class SearchVisasQueryHandler
{
    private readonly VisaRepository _visaRepository;

    public SearchVisasQueryHandler(VisaRepository visaRepository)
    {
        _visaRepository = visaRepository;
    }

    public VisaSearchResult Handle(SearchVisasQuery query)
    {
        // Implement search logic using the repository
        List<Visa> visas = _visaRepository.SearchVisas(query.SearchQuery);

        // Return the result
        return new VisaSearchResult { Visas = visas };
    }
}