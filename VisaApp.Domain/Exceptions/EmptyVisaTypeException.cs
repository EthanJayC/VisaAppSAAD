using VisaApp.Shared.Exceptions;

namespace VisaApp.Domain.Exceptions;

public class EmptyVisaTypeException : VisaAppException
{
    public EmptyVisaTypeException() : base("Visa Type is empty!")
    {
    }
}