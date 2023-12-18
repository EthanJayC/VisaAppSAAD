using VisaApp.Domain.Exceptions;

namespace VisaApp.Domain.ValueObjects;

public record VisaId
{
    public Guid Value { get; }

    public VisaId(Guid value)
    {
        if (value == Guid.Empty)
        {
            throw new EmptyVisaIdException();
        }
        
        Value = value;
    }

    public static implicit operator Guid(VisaId visaId)
        => visaId.Value;

    public static implicit operator VisaId(Guid visaId)
        => new(visaId);
}