using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaPrivata.Presenter;

namespace ClinicaPrivata.Model
{
    public class Intervento
    {
        private DateTime _data;
        private StatoIntervento _statoIntervento;
        private Paziente _paziente;
        private TipologiaIntervento _tipologia;
        private SalaOperatoria _salaOperatoria;
        private List<Medico> _equipe;

        public Intervento()
        {

        }
        public Intervento(Paziente paziente, TipologiaIntervento tipologia, SalaOperatoria sala, List<Medico> equipe, DateTime data)
        {
            this._paziente = paziente;
            this._tipologia = tipologia;
            this._salaOperatoria = sala;
            this._equipe = equipe;
            this._data = data;
            this.StatoIntervento = StatoIntervento.DeterminaTipo(this);
        }

        [EditableEnumerable("Equipe")]
        public List<Medico> Equipe
        {
            get { return _equipe; }
            set { _equipe = value; }
        }

        [NotYetEditable("SalaOperatoria")]
        public SalaOperatoria SalaOperatoria
        {
            get { return _salaOperatoria; }
            set { _salaOperatoria = value; }
        }

        [NotYetEditable("Tipologia")]
        public TipologiaIntervento Tipologia
        {
            get { return _tipologia; }
            set { _tipologia = value; }
        }

        [NotYetEditable("Paziente")]
        public Paziente Paziente
        {
            get { return _paziente; }
            set { _paziente = value; }
        }

        [NotYetEditable("Stati intervento")]
        public StatoIntervento StatoIntervento
        {
            get { return _statoIntervento; }
            set { _statoIntervento = value; }
        }

        [Editable("Data e ora")]
        public DateTime Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public override string ToString()
        {
            return _data + " " + _salaOperatoria + " " + _tipologia;
        }
        
    }
}
