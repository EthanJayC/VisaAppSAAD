using VisaApp.Domain.Entities;
using VisaApp.Domain.Factories;

namespace VisaApp.Infrastructure.Documents;

public class ExampleVisaDocument
{
    public Visa GetExampleVisa()
    {
        return new Visa(new Guid(), "Australia",
            new VisaDetails("Working Holiday Visa 417", "A visa designed for young holiday makers to work to supplement their travel with work",
                "EU, UK, CAN & USA participants can apply", 320), "Working Holiday", "12 months");
    }
}