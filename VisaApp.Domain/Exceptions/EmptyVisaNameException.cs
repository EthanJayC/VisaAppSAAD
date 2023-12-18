using VisaApp.Shared.Exceptions;

namespace VisaApp.Domain.Exceptions;

public class EmptyVisaNameException : VisaAppException
{
    public EmptyVisaNameException() : base("Visa name can't be empty.")
    {
        
    }
}