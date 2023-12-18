using VisaApp.Shared.Exceptions;

namespace VisaApp.Domain.Exceptions;

public class EmptyVisaIdException : VisaAppException
{
    public EmptyVisaIdException () : base("Visa Id is empty.") { }
}