using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaPrivata.Model
{
    //Filtro base
    abstract class FiltroBase : IFiltroInterventi
    {
        private readonly IFiltroInterventi _filtroInterventi;

        public readonly static IFiltroInterventi FiltroSuTutto = new _FiltroSuTutto();
        public readonly static IFiltroInterventi FiltroSuNiente = new _FiltroSuNiente();

        public FiltroBase(IFiltroInterventi filtroInterventi)
        {
            _filtroInterventi = filtroInterventi ?? FiltroSuTutto;
        }

        public IEnumerable<Intervento> GetInterventi()
        {
            return _filtroInterventi.GetInterventi().Where(Predicate);
        }

        public override string ToString()
        {
            if (_filtroInterventi is FiltroBase)
                return Description + " + " + _filtroInterventi.ToString();
            else
                return Description;
        }

        public abstract string Description { get; }

        protected abstract Func<Intervento, bool> Predicate { get; }

        private class _FiltroSuTutto : IFiltroInterventi
        {
            public IEnumerable<Intervento> GetInterventi()
            {
                return Documento.GetInstance().Interventi;
            }

            public override string ToString()
            {
                return "tutto";
            }
        }

        private class _FiltroSuNiente : IFiltroInterventi
        {
            public IEnumerable<Intervento> GetInterventi()
            {
                return new Intervento[0];
            }

            public override string ToString()
            {
                return "niente";
            }
        }
    }


    //Filtro per medico
    class FiltroPerMedico : FiltroBase
    {
        private readonly Medico _medico;

        public FiltroPerMedico(IFiltroInterventi filtroInterventi, Medico medico)
            : base(filtroInterventi)
        {
            if (medico == null)
                throw new ArgumentNullException("medico");
            _medico = medico;
        }

        public override string Description
        {
            get
            {
                return "Medico " + _medico.ToString();
            }
        }
        
        /*
        *
        *
            DA CAMBIARE -> SI DEVE CONTROLLARE CHE IL MEDICO APPARTENGA ALL'EQUIPE (DIPENDE DALL'IMPLEMENTAZIONE DELL'EQUIPE)
        * 
        * 
        */
        protected override Func<Intervento, bool> Predicate
        {
            get { return intervento => intervento.Equipe.Contains(_medico); }
        }
    }


    //Filtro per sala operatoria
    class FiltroPerSalaOperatoria : FiltroBase
    {
        private readonly SalaOperatoria _salaOperatoria;

        public FiltroPerSalaOperatoria(IFiltroInterventi filtroInterventi, SalaOperatoria salaOperatoria)
            : base(filtroInterventi)
        {
            if (salaOperatoria == null)
                throw new ArgumentNullException("sala operatoria");
            _salaOperatoria = salaOperatoria;
        }

        public override string Description
        {
            get { return "sala operatoria " + _salaOperatoria.ToString(); }
        }

        protected override Func<Intervento, bool> Predicate
        {
            get { return intervento => intervento.SalaOperatoria == _salaOperatoria; }
        }
    }


    //Filtro data iniziale
    class FiltroDallaData : FiltroBase
    {
        private readonly DateTime _dallaData;

        public FiltroDallaData(IFiltroInterventi filtroInterventi, DateTime dallaData)
            : base(filtroInterventi)
        {
            _dallaData = dallaData.Date;
        }

        public override string Description
        {
            get { return "dal giorno " + _dallaData.ToString("d"); }
        }

        protected override Func<Intervento, bool> Predicate
        {
            get { return intervento => _dallaData <= intervento.Data; }
        }
    }


    //Filtro data finale
    class FiltroAllaData : FiltroBase
    {
        private readonly DateTime _allaData;

        public FiltroAllaData(IFiltroInterventi filtroInterventi, DateTime allaData)
            : base(filtroInterventi)
        {
            _allaData = allaData.Date;
        }

        public override string Description
        {
            get { return "al giorno " + _allaData.ToString("d"); }
        }

        protected override Func<Intervento, bool> Predicate
        {
            get { return intervento => intervento.Data <= _allaData; }
        }
    }
}
