namespace VisaApp.Shared.Exceptions;

public abstract class VisaAppException : Exception
{
    protected VisaAppException(string message) : base(message) { }

    protected VisaAppException()
    {
        throw new NotImplementedException();
    }
}