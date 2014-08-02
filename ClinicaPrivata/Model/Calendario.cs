using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaPrivata.Model
{
    class Calendario : ICalendario
    {
        private IFiltroInterventi _filtroInterventi;
        //Cache
        private IEnumerable<Intervento> _elencoInterventi;

        public IFiltroInterventi FiltroInterventi
        {
            get { return _filtroInterventi ?? FiltroBase.FiltroSuTutto; }
            set
            {
                if (value != _filtroInterventi)
                {
                    _filtroInterventi = value;
                    Invalidate();
                }
            }
        }

        public IEnumerable<Intervento> GetInterventi()
        {
            if (_elencoInterventi == null)
            {
                _elencoInterventi = FiltroInterventi.GetInterventi();
            }
            return _elencoInterventi;
        }

        public override string ToString()
        {
            return FiltroInterventi.ToString();
        }

        public void Invalidate()
        {
            _elencoInterventi = null;
        }
    }
}
