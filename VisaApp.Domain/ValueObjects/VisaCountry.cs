using VisaApp.Domain.Exceptions;

namespace VisaApp.Domain.ValueObjects;

public record VisaCountry
{
    public string Value { get; }

    public VisaCountry(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new EmptyCountryNameException();
        }

        Value = value;
    }

    public static implicit operator string(VisaCountry name)
        => name.Value;

    public static implicit operator VisaCountry(string name)
        => new(name);
}