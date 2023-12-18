using VisaApp.Shared.Exceptions;

namespace VisaApp.Domain.Exceptions;

public class EmptyCountryNameException : VisaAppException
{
    public EmptyCountryNameException() : base("Country name is empty.")
    {
    }
}