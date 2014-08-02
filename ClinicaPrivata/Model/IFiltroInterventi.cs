using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaPrivata.Model
{
    public interface IFiltroInterventi
    {
        IEnumerable<Intervento> GetInterventi();
    }
}
