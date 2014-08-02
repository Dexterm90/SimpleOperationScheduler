using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaPrivata.Model;

namespace ClinicaPrivata.Persistence
{
    interface IDocumentoPersister
    {
        IDocumentoLoader GetLoader();
        void Save(Documento documento);
    }
}
