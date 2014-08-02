using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaPrivata.Presenter;

namespace ClinicaPrivata.Model
{
    public abstract class Dipendente
    {
        private string _nome;
        private string _cognome;
        private string _luogoNascita;
        private DateTime _dataNascita;
        private string _codiceFiscale;
        private string _username;
        private string _password;

        public Dipendente(string nome, string cognome, string luogoNascita, DateTime datanascita, string codiceFiscale, string username, string password)
        {
            _nome = nome;
            _cognome = cognome;
            _luogoNascita = luogoNascita;
            _dataNascita = datanascita;
            _codiceFiscale = codiceFiscale;
            _username = username;
            _password = password;
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        
        public string Username
        {
            get { return _username; }
            set { _username = value; }
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

        [Editable("Data di Nascita")]
        public DateTime DataNascita
        {
            get { return _dataNascita; }
            set { _dataNascita = value; }
        }

        [Editable("Luogo di Nascita")]
        public string LuogoNascita
        {
            get { return _luogoNascita; }
            set { _luogoNascita = value; }
        }

        

        

        public override string ToString()
        {
            return _nome + " " + _cognome;
        }

        public override bool Equals(object obj)
        {
            if (! (obj is Dipendente))
                return false;

            Dipendente d = (Dipendente)obj;
            if (d._codiceFiscale.Equals(this._codiceFiscale))
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        
    }

    public class Medico : Dipendente
    {
        private string _codiceOrdineMedici;
        private Specializzazione _specializzazione;

        public Medico(string nome, string cognome, string luogoNascita, DateTime datanascita, string codiceFiscale,
            string username, string password, string codiceOrdineMedici, Specializzazione specializzazione)
            : base(nome, cognome, luogoNascita, datanascita, codiceFiscale, username, password)
        {
            _codiceOrdineMedici = codiceOrdineMedici;
            _specializzazione = specializzazione;
        }

        [NotYetEditable("Specializzazione")]
        public Specializzazione Specializzazione
        {
            get { return _specializzazione; }
            set { _specializzazione = value; }
        }

        [Editable("Codice Ordine Medici")]
        public string CodiceOrdineMedici
        {
            get { return _codiceOrdineMedici; }
            set { _codiceOrdineMedici = value; }
        }

        public override string ToString()
        {
            return base.ToString() + " " + _specializzazione;
        }
        
    }

    public class Segretario : Dipendente
    {
        public Segretario(string nome, string cognome, string luogoNascita, DateTime datanascita, string codiceFiscale,
            string username, string password)
            : base(nome, cognome, luogoNascita, datanascita, codiceFiscale, username, password)
        { 
        }
    }

    public class Amministratore : Segretario
    {
        public Amministratore(string nome, string cognome, string luogoNascita, DateTime datanascita, string codiceFiscale,
            string username, string password)
            : base(nome, cognome, luogoNascita, datanascita, codiceFiscale, username, password)
        { 
        }
    }
}
