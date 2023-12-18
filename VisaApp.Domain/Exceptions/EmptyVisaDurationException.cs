using VisaApp.Shared.Exceptions;

namespace VisaApp.Domain.Exceptions;

public class EmptyVisaDurationException : VisaAppException
{
    public EmptyVisaDurationException() : base("Visa duration is empty")
    {
        
    }
}