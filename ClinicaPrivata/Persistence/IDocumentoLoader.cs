using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaPrivata.Model;

namespace ClinicaPrivata.Persistence
{
    interface IDocumentoLoader
    {
        List<Paziente> LoadPazienti();
        List<Dipendente> LoadDipendenti();
        List<Intervento> LoadInterventi();
        List<SalaOperatoria> LoadSaleOperatorie();
        List<TipologiaIntervento> LoadTipologieIntervento();
        List<Specializzazione> LoadSpecializzazioni();
    }
}
