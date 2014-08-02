using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaPrivata.Presenter;

namespace ClinicaPrivata.Model
{
    public class Specializzazione
    {
        private static int _lastId = 0;
        private int _id;
        private string _descrizione;

        public Specializzazione(string descrizione)
        {
            _lastId++;
            _id = _lastId;
            _descrizione = descrizione;
        }

        public int Id
        {
            get { return _id; }
        }

        [Editable("Descrizione")]
        public string Descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }

        public override string ToString()
        {
            return _descrizione;
        }
        
    }
}
