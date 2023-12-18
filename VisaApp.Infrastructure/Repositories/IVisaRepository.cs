using VisaApp.Domain.Entities;

namespace VisaApp.Infrastructure.Repositories;

public interface IVisaRepository
{
    Visa GetVisaFromRepository();
    List<Visa> SearchVisas(string query);
}