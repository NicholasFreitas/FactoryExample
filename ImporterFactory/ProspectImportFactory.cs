﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    class ProspectImportFactory : IImporterFactory
    {
        public IImporter CreateImporter()
        {
            return new ProspectImporter();
        }
    }
}
