using VisaApp.Domain.ValueObjects;

namespace VisaApp.Domain.Entities;

public class Visa
{
    public VisaId Id { get; set; }

    public VisaCountry Country { get; }
    public VisaDetails Details { get; }
    public VisaType VisaType { get; }
    public VisaDuration Duration { get;}

    public Visa(VisaId id, VisaCountry country, VisaDetails details, VisaType visaType, VisaDuration duration)
    {
        Id = id;
        Country = country;
        Details = details;
        VisaType = visaType;
        Duration = duration;
    }
}