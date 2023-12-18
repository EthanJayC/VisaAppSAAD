using System.Reflection.Metadata;
using VisaApp.Domain.Entities;
using VisaApp.Infrastructure.Repositories;

namespace VisaApp.Application.Queries;

public class SearchVisasQuery
{
    public string SearchQuery { get; set; }
}

