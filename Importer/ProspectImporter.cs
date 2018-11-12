using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    class ProspectImporter : IImporter
    {
        public void Import(ILeadType prospect)
        {
            Console.WriteLine("Import Prospect.");
        }


    }
}
