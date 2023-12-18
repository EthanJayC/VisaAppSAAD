using System.Dynamic;
using VisaApp.Domain.Exceptions;

namespace VisaApp.Domain.ValueObjects;

public record VisaDuration
{
    public string Value { get; }

    public VisaDuration(string value)
    {
        if (string.IsNullOrEmpty(Value))
        {
            throw new EmptyVisaDurationException();
        }

        Value = value;
    }

    public static implicit operator string(VisaDuration name) 
        => name.Value;

    public static implicit operator VisaDuration(string name)
        => new (name);
}