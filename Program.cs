using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lead factory
            var leadFactory = new LeadTypeFactory();

            // two new leadtypes created through the factory
            var lead = leadFactory.GetNewLead();
            var prospect = leadFactory.GetNewProspect();

            //Factory for prospect
            var pImportFactory = new ProspectImportFactory();
            var prospectimporter = pImportFactory.CreateImporter();
            prospectimporter.Import(prospect);


            //factory for lead
            var lImportFactory = new LeadImportFactory();
            var leadimporter = lImportFactory.CreateImporter();
            leadimporter.Import(lead);


            Console.WriteLine("========================");
            Console.WriteLine("Complete.");
            Console.ReadLine();

        }
    }
}
