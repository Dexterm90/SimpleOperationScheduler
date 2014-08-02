using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ClinicaPrivata.Persistence;
using System.Timers;

namespace ClinicaPrivata.Model
{
    class Documento
    {
        private static Documento _instance;
        private Timer _timer = new Timer();
        private List<Intervento> _interventi;
        private List<Dipendente> _dipendenti;
        private List<Paziente> _pazienti;
        private List<SalaOperatoria> _saleOperatorie;
        private List<Specializzazione> _specializzazioni;
        private List<TipologiaIntervento> _tipologieIntervento;
        private Boolean _toBeSaved = false;

        public event EventHandler Changed;

        private Documento()
        {
            New();

            _timer.Interval = 60000;
            _timer.Elapsed += onElapsed;
        }

        public void onElapsed(Object sender, EventArgs args)
        {
            foreach (Intervento i in _interventi)
            {
                if (i.StatoIntervento is ClinicaPrivata.Model.StatoInterventoFuturo)
                {
                    i.StatoIntervento = StatoIntervento.DeterminaTipo(i);
                }
            }
        }

        public static Documento GetInstance()
        {
            if (_instance == null)
                _instance = new Documento();
            return _instance;
        }

        public void New()
        {
            _interventi = new List<Intervento>();
            _dipendenti = new List<Dipendente>();
            _pazienti = new List<Paziente>();
            _saleOperatorie = new List<SalaOperatoria>();
            _specializzazioni = new List<Specializzazione>();
            _tipologieIntervento = new List<TipologiaIntervento>();
            OnChanged();
        }


        #region Interventi

        public List<Intervento> Interventi
        {
            get { return _interventi; }
        }

        public void Add(Intervento intervento)
        {
            if (intervento == null)
                throw new ArgumentNullException("intervento");
            _interventi.Add(intervento);
            _toBeSaved = true;

        }

        #endregion

        #region Dipendenti

        public List<Dipendente> Dipendenti
        {
            get { return _dipendenti; }
        }

        public void Add(Dipendente dipendente)
        {
            if (dipendente == null)
                throw new ArgumentNullException("dipendente");
            _dipendenti.Add(dipendente);
            _toBeSaved = true;
        }

        #endregion

        #region Medici

        public List<Medico> Medici
        {
            get 
            { 
                List<Medico> medici = new List<Medico>();

                foreach(Dipendente d in _dipendenti)
                    if (d.GetType().Equals(Type.GetType("ClinicaPrivata.Model.Medico")))
                    {
                        Medico m = (Medico)d;
                        medici.Add(m);
                    }
                
                
                return medici;
            }
        }

        #endregion

        #region Segretari

        public List<Segretario> Segretari
        {
            get
            {
                List<Segretario> segretari = new List<Segretario>();

                foreach (Dipendente d in _dipendenti)
                    if (d is Segretario)
                    {
                        Segretario s = (Segretario)d;
                        segretari.Add(s);
                    }


                return segretari;
            }
        }

        #endregion

        #region Pazienti

        public List<Paziente> Pazienti
        {
            get { return _pazienti; }
        }

        public void Add(Paziente paziente)
        {
            if (paziente == null)
                throw new ArgumentNullException("paziente");
            _pazienti.Add(paziente);
            _toBeSaved = true;
        }

        #endregion

        #region SaleOperatorie

        public List<SalaOperatoria> SaleOperatorie
        {
            get { return _saleOperatorie; }
        }

        public void Add(SalaOperatoria salaOperatoria)
        {
            if (salaOperatoria == null)
                throw new ArgumentNullException("salaOperatoria");
            _saleOperatorie.Add(salaOperatoria);
            _toBeSaved = true;
        }

        #endregion

        #region Specializzazioni

        public List<Specializzazione> Specializzazioni
        {
            get { return _specializzazioni; }
        }

        public void Add(Specializzazione specializzazione)
        {
            if (specializzazione == null)
                throw new ArgumentNullException("specializzazione");
            _specializzazioni.Add(specializzazione);
            _toBeSaved = true;
        }

        #endregion

        #region Tipologie intervento

        public List<TipologiaIntervento> TipologieIntervento
        {
            get { return _tipologieIntervento; }
        }

        public void Add(TipologiaIntervento tipologiaIntervento)
        {
            if (tipologiaIntervento == null)
                throw new ArgumentNullException("tipologiaIntervento");
            _tipologieIntervento.Add(tipologiaIntervento);
            _toBeSaved = true;
        }

        #endregion

        protected virtual void OnChanged()
        {
            if (Changed != null)
                Changed(this, EventArgs.Empty);
        }

        public bool needToBeSaved()
        {
            return _toBeSaved;
        }

        public void setToBeSaved()
        {
            _toBeSaved = true;
        }


        public void Load(IDocumentoPersister persister)
        {
            if (persister == null)
                throw new ArgumentNullException("persister");
            IDocumentoLoader loader = persister.GetLoader();
            _specializzazioni = loader.LoadSpecializzazioni();
            _saleOperatorie = loader.LoadSaleOperatorie();
            _tipologieIntervento = loader.LoadTipologieIntervento();
            _pazienti = loader.LoadPazienti();
            _dipendenti = loader.LoadDipendenti();
            _interventi = loader.LoadInterventi();
            OnChanged();
        }


        public void Save(IDocumentoPersister persister)
        {
            if (persister == null)
                throw new ArgumentNullException("persister");
            persister.Save(this);
            _toBeSaved = false;
        }
    }
}
