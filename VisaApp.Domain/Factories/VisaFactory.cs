using VisaApp.Domain.Entities;
using VisaApp.Domain.ValueObjects;

namespace VisaApp.Domain.Factories;

public class VisaFactory : IVisaFactory
{
    public Visa CreateVisa(VisaId id,
        VisaCountry country,
        VisaDetails details,
        VisaType type,
        VisaDuration duration)
    {
        return new Visa(id, country, details, type, duration);
    }
}