using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaPrivata.Presenter;

namespace ClinicaPrivata.Model
{
    public class TipologiaIntervento
    {
        private static int _lastId = 0;
        private int _id;
        private string _nome;
        private string _descrizione;
        private int _durata;
        private Dictionary<Specializzazione, int> _dictionarySpecializzazioni;
        private HashSet<SalaOperatoria> _saleOperatorieUtilizzabili;

        public TipologiaIntervento(string nome, string descrizione, int durata)
        {
            _lastId++; 

            _id = _lastId;
            _nome = nome;
            _descrizione = descrizione;
            _durata = durata;
            _dictionarySpecializzazioni = new Dictionary<Specializzazione, int>();
            _saleOperatorieUtilizzabili = new HashSet<SalaOperatoria>();
        }

        public int Id
        {
            get { return _id; }
        }

        //[EditableEnumerable("Sale Operatorie Utilizzabili")]
        public HashSet<SalaOperatoria> SaleOperatorieUtilizzabili
        {
            get { return _saleOperatorieUtilizzabili; }
            set { _saleOperatorieUtilizzabili = value; }
        }

        public void AddSalaOperatoria(SalaOperatoria salaOperatoria)
        {
            _saleOperatorieUtilizzabili.Add(salaOperatoria);
        }

        public Dictionary<Specializzazione, int> DictionarySpecializzazioni
        {
            get { return _dictionarySpecializzazioni; }
            set { _dictionarySpecializzazioni = value; }
        }

        public void AddEntryInDictionary(Specializzazione specializzazione, int value)
        {
            _dictionarySpecializzazioni.Add(specializzazione, value);
        }

        [Editable("Nome")]
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        [Editable("Descrizione")]
        public string Descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }

        [Editable("Durata")]
        public int Durata
        {
            get { return _durata; }
            set { _durata = value; }
        }

        public override string ToString()
        {
            return _nome;
        }
        
    }
}
