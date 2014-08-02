using System;
using System.Collections.Generic;

namespace ClinicaPrivata.Model
{
    public interface ICalendario
    {
        IFiltroInterventi FiltroInterventi { get; set; }
        IEnumerable<Intervento> GetInterventi();
    }
}
