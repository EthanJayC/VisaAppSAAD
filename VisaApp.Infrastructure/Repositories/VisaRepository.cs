using VisaApp.Domain.Entities;
using VisaApp.Domain.Factories;
using VisaApp.Domain.ValueObjects;
using VisaApp.Infrastructure.Documents;

namespace VisaApp.Infrastructure.Repositories;

public class VisaRepository : IVisaRepository
{
   private readonly IVisaFactory _visaFactory;

   public VisaRepository(IVisaFactory visaFactory)
   {
       _visaFactory = visaFactory;
   }

   public Visa GetVisaFromRepository()
   {
       //Retrieve the visa using the ExampleVisaDocument
       ExampleVisaDocument visa = new ExampleVisaDocument();
       Visa exampleVisa = visa.GetExampleVisa();

       //This is mocking a mapper that'd get the data and turn it into an object the application can read
       return _visaFactory.CreateVisa(exampleVisa.Id, exampleVisa.Country, exampleVisa.Details, exampleVisa.VisaType,
           exampleVisa.Duration);
   }

    public List<Visa> SearchVisas(string query)
    {
        // Implements search logic using the repository
        // This is where you'd search for visas based on the provided query
        // For simplicity, let's assume you have a list of visas and you're filtering based on the country
        ExampleVisaDocument visaDocument = new ExampleVisaDocument();
        var allVisas = new List<Visa> { visaDocument.GetExampleVisa() };
        return allVisas.Where(visa => visa.Country.Value.Contains(query)).ToList();
    }

    public Visa GetVisaById(Guid id)
    {
        // In a real-world scenario, you would fetch the visa by its ID from your data source
        // For simplicity, we'll return the example visa if the ID matches
        ExampleVisaDocument visaDocument = new ExampleVisaDocument();
        var exampleVisa = visaDocument.GetExampleVisa();

        if ((Guid)exampleVisa.Id == id)
        {
            return _visaFactory.CreateVisa(exampleVisa.Id, exampleVisa.Country, exampleVisa.Details, exampleVisa.VisaType, exampleVisa.Duration);
        }

        return null; // Return null if the visa is not found
    }
}