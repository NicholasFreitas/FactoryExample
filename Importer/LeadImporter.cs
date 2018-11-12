using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    class LeadImporter : IImporter
    {
        public void Import(ILeadType lead)
        {
            Console.WriteLine("Import Lead");
        }

    }
}
