using VisaApp.Domain.Exceptions;

namespace VisaApp.Domain.Entities;

public class VisaDetails
{
    public string VisaName { get; }
    public string VisaDescription { get; }
    public string EligibilityRequirements { get; }
    public int VisaCost { get; }

    public VisaDetails(string visaName, string visaDescription, string eligibilityRequirements,int visaCost)
    {
        if (string.IsNullOrWhiteSpace(visaName))
        {
            throw new EmptyVisaNameException();
        }

        VisaName = visaName;
        VisaDescription = visaDescription;
        EligibilityRequirements = eligibilityRequirements;
        VisaCost = visaCost;
    }
}