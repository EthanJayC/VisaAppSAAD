using System.Net.NetworkInformation;
using VisaApp.Domain.Exceptions;

namespace VisaApp.Domain.ValueObjects;

public record VisaType
{
    public string Value { get; }

    public VisaType(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new EmptyVisaTypeException();
        }
            
        Value = value;
    }

    //Prevent the need to explicitly convert the type elsewhere in the application
    public static implicit operator string (VisaType name)
        => name.Value;

    public static implicit operator VisaType(string name)
        => new (name);
}