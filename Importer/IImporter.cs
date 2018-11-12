using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    interface IImporter
    {
        void Import(ILeadType lead);
    }
}
