using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaPrivata.Presenter;

namespace ClinicaPrivata.Model
{
    public abstract class StatoIntervento
    {
        public static StatoIntervento DeterminaTipo(Intervento intervento)
        {
            if (intervento.Data <= DateTime.Now)
                return new StatoInterventoPassato();
            else
                return new StatoInterventoFuturo();
        }
    }

    public class StatoInterventoPassato : StatoIntervento
    {
        private string _esito;
        private string _note;

        [Editable("Note")]
        public string Note
        {
            get { return _note; }
            set { _note = value; }
        }

        [Editable("Esito")]
        public string Esito
        {
            get { return _esito; }
            set { _esito = value; }
        }

    }

    public class StatoInterventoFuturo : StatoIntervento
    {
    }
}
