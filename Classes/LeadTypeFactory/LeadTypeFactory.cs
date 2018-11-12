using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    class LeadTypeFactory : ILeadTypeFactory
    {
        public ILeadType GetNewCustomer()
        {
            return new Customer();
        }

        public ILeadType GetNewLead()
        {
            return new Lead();
        }

        public ILeadType GetNewProspect()
        {
            return new Prospect();
        }
    }
}
