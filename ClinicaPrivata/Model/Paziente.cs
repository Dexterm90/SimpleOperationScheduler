using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaPrivata.Presenter;

namespace ClinicaPrivata.Model
{
    public class Paziente
    {
        private string _nome;
        private string _cognome;
        private string _codiceFiscale;
        private string _luogoNascita;
        private DateTime _dataNascita;
        private string _telefono;
        private Indirizzo _indirizzo;
        private CartellaClinica _cartellaClinica;

        public Paziente(string nome, string cognome, string codiceFiscale)
        {
            if (nome == null)
                throw new ArgumentNullException("nome");
            if (cognome == null)
                throw new ArgumentNullException("cognome");
            _nome = nome;
            _cognome = cognome;
            _codiceFiscale = codiceFiscale;
        }

        public Paziente(string nome, string cognome, string codiceFiscale, string luogoNascita, DateTime dataNascita,
            string telefono, Indirizzo indirizzo, CartellaClinica cartellaClinica)
        {
            if (nome == null)
                throw new ArgumentNullException("nome");
            if (cognome == null)
                throw new ArgumentNullException("cognome");
            _nome = nome;
            _cognome = cognome;
            _codiceFiscale = codiceFiscale;
            _luogoNascita = luogoNascita;
            _dataNascita = dataNascita;
            _telefono = telefono;
            _indirizzo = indirizzo;
            _cartellaClinica = cartellaClinica;
        }

        [Editable("Nome")]
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        [Editable("Cognome")]
        public string Cognome
        {
            get { return _cognome; }
            set { _cognome = value; }
        }

        [Editable("Codice Fiscale")]
        public string CodiceFiscale
        {
            get { return _codiceFiscale; }
            set { _codiceFiscale = value; }
        }

        [Editable("Luogo di Nascita")]
        public string LuogoNascita
        {
            get { return _luogoNascita; }
            set { _luogoNascita = value; }
        }

        [Editable("Telefono")]
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        [Editable("Data di Nascita")]
        public DateTime DataNascita
        {
            get { return _dataNascita; }
            set { _dataNascita = value; }
        }

        [NotYetEditable("Indirizzo")]
        public Indirizzo Indirizzo
        {
            get { return _indirizzo; }
            set { _indirizzo = value; }
        }

        //[NotYetEditable("Cartella Clinica")]
        public CartellaClinica CartellaClinica
        {
            get { return _cartellaClinica; }
            set { _cartellaClinica = value; }
        }

        public override string ToString()
        {
            return _nome + " " + _cognome;
        }

    }

    public class Indirizzo
    {
        private string _via;
        private string _numeroCivico;
        private string _località;
        private int _cap;
        private string _provincia;
        private string _nazione;

        public Indirizzo()
        {
            _via = null;
            _numeroCivico = null;
            _località = null;
            _cap = 0;
            _provincia = null;
            _nazione = null;
        }

        public Indirizzo(string via, string numeroCivico, string località, int cap, string provincia, string nazione)
        {
            _via = via;
            _numeroCivico = numeroCivico;
            _località = località;
            _cap = cap;
            _provincia = provincia;
            _nazione = nazione;
        }

        [Editable("Via")]
        public string Via
        {
            get { return _via; }
            set { _via = value; }
        }

        [Editable("Numero Civico")]
        public string NumeroCivico
        {
            get { return _numeroCivico; }
            set { _numeroCivico = value; }
        }

        [Editable("Località")]
        public string Località
        {
            get { return _località; }
            set { _località = value; }
        }

        [Editable("Cap")]
        public int Cap
        {
            get { return _cap; }
            set { _cap = value; }
        }

        [Editable("Provincia")]
        public string Provincia
        {
            get { return _provincia; }
            set { _provincia = value; }
        }

        [Editable("Nazione")]
        public string Nazione
        {
            get { return _nazione; }
            set { _nazione= value; }
        }
        
    }

    public class CartellaClinica
    {
        private string _patologie;
        private string _allergie;
        private FattoreRh _fattoreRh;
        private GruppoSanguigno _gruppoSanguigno;

        [Editable("Gruppo Sanguigno")]
        public GruppoSanguigno GruppoSanguigno
        {
            get { return _gruppoSanguigno; }
            set { _gruppoSanguigno = value; }
        }

        [Editable("FattoreRh")]
        public FattoreRh FattoreRh
        {
            get { return _fattoreRh; }
            set { _fattoreRh = value; }
        }

        [Editable("Allergie")]
        public string Allergie
        {
            get { return _allergie; }
            set { _allergie = value; }
        }

        [Editable("Patologie")]
        public string Patologie
        {
            get { return _patologie; }
            set { _patologie = value; }
        }
        
    }

    public enum GruppoSanguigno
    {
        A, B, AB, ZERO
    }

    public enum FattoreRh
    {
        Positivo, Negativo
    }

}
