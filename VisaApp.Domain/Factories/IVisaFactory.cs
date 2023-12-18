using VisaApp.Domain.Entities;
using VisaApp.Domain.ValueObjects;

namespace VisaApp.Domain.Factories
{
    public interface IVisaFactory
    {
        Visa CreateVisa(VisaId id, VisaCountry country, VisaDetails details, VisaType type, VisaDuration duration);
    }
}