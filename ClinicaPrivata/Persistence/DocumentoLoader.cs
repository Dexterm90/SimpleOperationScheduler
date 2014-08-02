using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using ClinicaPrivata.Model;

namespace ClinicaPrivata.Persistence
{
    public class DocumentoLoader : IDocumentoLoader
    {
        PazientiDocumentoLoader _pazientiDocumentoLoader;
        DipendentiDocumentoLoader _dipendentiDocumentoLoader;
        InterventiDocumentoLoader _interventiDocumentoLoader;
        SaleOperatorieDocumentoLoader _saleOperatorieDocumentoLoader;
        TipologieInterventoDocumentoLoader _tipologieInterventoDocumentoLoader;
        SpecializzazioniDocumentoLoader _specializzazioniDocumentoLoader;

        #region IDocumentoLoader members

        public DocumentoLoader(string filePazienti, string fileDipendenti, string fileInterventi, string fileSaleOperatorie, string fileTipologie, string fileSpecializzazioni)
        {
            _pazientiDocumentoLoader = new PazientiDocumentoLoader(filePazienti);
            _dipendentiDocumentoLoader = new DipendentiDocumentoLoader(fileDipendenti);
            _interventiDocumentoLoader = new InterventiDocumentoLoader(fileInterventi);
            _saleOperatorieDocumentoLoader = new SaleOperatorieDocumentoLoader(fileSaleOperatorie);
            _tipologieInterventoDocumentoLoader = new TipologieInterventoDocumentoLoader(fileTipologie);
            _specializzazioniDocumentoLoader = new SpecializzazioniDocumentoLoader(fileSpecializzazioni);
        }

        public List<Paziente> LoadPazienti()
        {
            return _pazientiDocumentoLoader.Load();
        }

        public List<Dipendente> LoadDipendenti()
        {
            return _dipendentiDocumentoLoader.Load();
        }

        public List<Intervento> LoadInterventi()
        {
            return _interventiDocumentoLoader.Load();
        }

        public List<SalaOperatoria> LoadSaleOperatorie()
        {
            return _saleOperatorieDocumentoLoader.Load();
        }

        public List<TipologiaIntervento> LoadTipologieIntervento()
        {
            return _tipologieInterventoDocumentoLoader.Load();
        }

        public List<Specializzazione> LoadSpecializzazioni()
        {
            return _specializzazioniDocumentoLoader.Load();
        }


        #endregion

        private class PazientiDocumentoLoader
        {
            private readonly XmlDocument _xmlDocument;

            public PazientiDocumentoLoader(string fileName)
            {
                _xmlDocument = new XmlDocument();
                _xmlDocument.Load(fileName);
            }

            public List<Paziente> Load()
            {
                List<Paziente> pazienti = new List<Paziente>();
                XmlElement rootElement = (XmlElement)_xmlDocument.SelectSingleNode("Documento/Pazienti");
                foreach (XmlElement childElement in rootElement.SelectNodes("Paziente"))
                {
                    pazienti.Add(LoadPaziente(childElement));
                }
                return pazienti;
            }

            private Paziente LoadPaziente(XmlElement pazienteElement)
            {
                string nome = pazienteElement.GetAttribute("nome");
                string cognome = pazienteElement.GetAttribute("cognome");
                string codiceFiscale = pazienteElement.GetAttribute("cf");
                string luogoDiNascita = pazienteElement.GetAttribute("luogoDiNascita");
                DateTime dataDiNascita = DateTime.Parse(pazienteElement.GetAttribute("dataDiNascita"));
                string telefono = pazienteElement.GetAttribute("telefono");
                XmlNode indirizzo = pazienteElement.SelectSingleNode("Indirizzo");
                Indirizzo i = new Indirizzo();
                string via = indirizzo.Attributes.GetNamedItem("via").Value;
                string numeroCivico = indirizzo.Attributes.GetNamedItem("numeroCivico").Value;
                string località = indirizzo.Attributes.GetNamedItem("località").Value;
                int cap = int.Parse(indirizzo.Attributes.GetNamedItem("cap").Value);
                string provincia = indirizzo.Attributes.GetNamedItem("provincia").Value;
                string nazione = indirizzo.Attributes.GetNamedItem("nazione").Value;
                XmlNode cartellaClinica = pazienteElement.SelectSingleNode("CartellaClinica");
                CartellaClinica c = new CartellaClinica();
                string patologie = cartellaClinica.Attributes.GetNamedItem("patologie").Value;
                string allergie = cartellaClinica.Attributes.GetNamedItem("allergie").Value;
                int fattoreRh = int.Parse(cartellaClinica.Attributes.GetNamedItem("fattoreRh").Value);
                int gruppoSanguigno = int.Parse(cartellaClinica.Attributes.GetNamedItem("gruppoSanguigno").Value);
                c.Allergie = allergie;
                c.Patologie = patologie;
                c.FattoreRh = (FattoreRh) fattoreRh;
                c.GruppoSanguigno = (GruppoSanguigno) gruppoSanguigno;
                i.Via = via;
                i.NumeroCivico = numeroCivico;
                i.Località = località;
                i.Cap = cap;
                i.Provincia = provincia;
                i.Nazione = nazione;
                Paziente paziente = new Paziente(nome, cognome, codiceFiscale, luogoDiNascita, dataDiNascita, telefono, i, c);
                return paziente;
            }
        }

        private class DipendentiDocumentoLoader
        {
            private readonly XmlDocument _xmlDocument;

            public DipendentiDocumentoLoader(string fileName)
            {
                _xmlDocument = new XmlDocument();
                _xmlDocument.Load(fileName);
            }

            public List<Dipendente> Load()
            {
                List<Dipendente> dipendenti = new List<Dipendente>();
                XmlElement rootElement = (XmlElement)_xmlDocument.SelectSingleNode("Documento/Dipendenti");
                foreach (XmlElement childElement in rootElement.SelectNodes("Medico"))
                {
                    dipendenti.Add(LoadMedico(childElement));
                }
                foreach (XmlElement childElement in rootElement.SelectNodes("Segretario"))
                {
                    dipendenti.Add(LoadSegretario(childElement));
                }
                foreach (XmlElement childElement in rootElement.SelectNodes("Amministratore"))
                {
                    dipendenti.Add(LoadAmministratore(childElement));
                }
                return dipendenti;
            }

            private Medico LoadMedico(XmlElement medicoElement)
            {
                string nome = medicoElement.GetAttribute("nome");
                string cognome = medicoElement.GetAttribute("cognome");
                string codiceFiscale = medicoElement.GetAttribute("cf");
                string username = medicoElement.GetAttribute("username");
                string password = medicoElement.GetAttribute("password");
                string codiceOrdineMedici = medicoElement.GetAttribute("codiceOrdineMedici");
                string specializzazioneString = medicoElement.GetAttribute("specializzazione");
                Specializzazione specializzazione = null;
                foreach (Specializzazione spec in Documento.GetInstance().Specializzazioni)
                {
                    if (spec.Descrizione.Equals(specializzazioneString))
                    {
                        specializzazione=spec;
                        break;
                    }
                }
                if (specializzazione == null)
                    throw new ArgumentException();

                Medico medico = new Medico(nome, cognome, null, new DateTime(), codiceFiscale, username, password, codiceOrdineMedici, specializzazione);
                return medico;
            }

            private Segretario LoadSegretario(XmlElement segretarioElement)
            {
                string nome = segretarioElement.GetAttribute("nome");
                string cognome = segretarioElement.GetAttribute("cognome");
                string codiceFiscale = segretarioElement.GetAttribute("cf");
                string username = segretarioElement.GetAttribute("username");
                string password = segretarioElement.GetAttribute("password");
                Segretario segretario = new Segretario(nome, cognome, null, new DateTime(), codiceFiscale, username, password);
                return segretario;
            }

            private Amministratore LoadAmministratore(XmlElement adminElement)
            {
                string nome = adminElement.GetAttribute("nome");
                string cognome = adminElement.GetAttribute("cognome");
                string codiceFiscale = adminElement.GetAttribute("cf");
                string username = adminElement.GetAttribute("username");
                string password = adminElement.GetAttribute("password");
                Amministratore admin = new Amministratore(nome, cognome, null, new DateTime(), codiceFiscale, username, password);
                return admin;
            }
        }

        private class InterventiDocumentoLoader
        {
            private readonly XmlDocument _xmlDocument;

            public InterventiDocumentoLoader(string fileName)
            {
                _xmlDocument = new XmlDocument();
                _xmlDocument.Load(fileName);
            }

            public List<Intervento> Load()
            {
                List<Intervento> interventi = new List<Intervento>();
                XmlElement rootElement = (XmlElement)_xmlDocument.SelectSingleNode("Documento/Interventi");
                foreach (XmlElement childElement in rootElement.SelectNodes("intervento"))
                {
                    interventi.Add(LoadIntervento(childElement));
                }
                
                return interventi;
            }

            private Intervento LoadIntervento(XmlElement interventoElement)
            {
                Intervento intervento = new Intervento();

                DateTime data = DateTime.Parse(interventoElement.GetAttribute("data"));
                int oraDiInizio = int.Parse(interventoElement.GetAttribute("oraDiInizio"));
                data = data.AddHours(oraDiInizio);
                string cfPaziente = interventoElement.GetAttribute("cfPaziente");
                int idTipologiaIntervento = int.Parse(interventoElement.GetAttribute("idTipologiaIntervento"));
                string codiceSalaOperatoria = interventoElement.GetAttribute("codiceSalaOperatoria");

                List<string> codiciOrdineMedici = new List<string>();
                //codici dei medici
                foreach (XmlElement childElement in interventoElement.SelectNodes("medico"))
                {
                    string codiceOrdineMedici = childElement.GetAttribute("codiceOrdineMedici");
                    codiciOrdineMedici.Add(codiceOrdineMedici);
                }


                //paziente
                Paziente paziente = null;
                foreach (Paziente p in Documento.GetInstance().Pazienti)
                {
                    if (p.CodiceFiscale.Equals(cfPaziente))
                    {
                        paziente = p;
                        break;
                    }
                }
                if (paziente == null)
                    throw new ArgumentException();

                //tipologiaIntervento
                TipologiaIntervento tipologiaIntervento = null;
                foreach (TipologiaIntervento t in Documento.GetInstance().TipologieIntervento)
                {
                    if (t.Id.Equals(idTipologiaIntervento))
                    {
                        tipologiaIntervento = t;
                        break;
                    }
                }
                if (tipologiaIntervento == null)
                    throw new ArgumentException();

                //salaOperatoria
                SalaOperatoria sala = null;
                foreach(SalaOperatoria s in Documento.GetInstance().SaleOperatorie)
                {
                    if (s.Codice.Equals(codiceSalaOperatoria))
                    {
                        sala = s;
                        break;
                    }
                }
                if (sala == null)
                    throw new ArgumentException();

                //medici
                List<Medico> equipe = new List<Medico>();
                foreach (string codiceMedico in codiciOrdineMedici)
                {
                    Medico medico = null;

                    foreach (Medico m in Documento.GetInstance().Medici)
                    {
                        if (m.CodiceOrdineMedici.Equals(codiceMedico))
                        {
                            medico = m;
                            break;
                        }
                    }
                    if(medico == null)
                        throw new ArgumentException();

                    equipe.Add(medico);
                }

                intervento.Data = data;
                intervento.Paziente = paziente;
                intervento.Tipologia = tipologiaIntervento;
                intervento.SalaOperatoria = sala;
                intervento.Equipe = equipe;

                intervento.StatoIntervento = StatoIntervento.DeterminaTipo(intervento);
                if (intervento.StatoIntervento is StatoInterventoPassato)
                {
                    string esito = interventoElement.GetAttribute("esito");
                    string note = interventoElement.GetAttribute("note");
                    ((StatoInterventoPassato)intervento.StatoIntervento).Esito = esito;
                    ((StatoInterventoPassato)intervento.StatoIntervento).Note = note;
                }
                return intervento;
            }
 
        }

        private class SaleOperatorieDocumentoLoader
        {
            private readonly XmlDocument _xmlDocument;

            public SaleOperatorieDocumentoLoader(string fileName)
            {
                _xmlDocument = new XmlDocument();
                _xmlDocument.Load(fileName);
            }

            public List<SalaOperatoria> Load()
            {
                List<SalaOperatoria> saleOperatorie = new List<SalaOperatoria>();
                XmlElement rootElement = (XmlElement)_xmlDocument.SelectSingleNode("Documento/SaleOperatorie");
                foreach (XmlElement childElement in rootElement.SelectNodes("SalaOperatoria"))
                {
                    saleOperatorie.Add(LoadSalaOperatoria(childElement));
                }

                return saleOperatorie;
            }

            private SalaOperatoria LoadSalaOperatoria(XmlElement salaOperatoriaElement)
            {
                string codice = salaOperatoriaElement.GetAttribute("codice");
                SalaOperatoria salaOperatoria = new SalaOperatoria(codice);
                return salaOperatoria;
            }

        }


        private class TipologieInterventoDocumentoLoader
        {
            private readonly XmlDocument _xmlDocument;

            public TipologieInterventoDocumentoLoader(string fileName)
            {
                _xmlDocument = new XmlDocument();
                _xmlDocument.Load(fileName);
            }

            public List<TipologiaIntervento> Load()
            {
                List<TipologiaIntervento> tipologie = new List<TipologiaIntervento>();
                XmlElement rootElement = (XmlElement)_xmlDocument.SelectSingleNode("Documento/TipologieIntervento");
                foreach (XmlElement childElement in rootElement.SelectNodes("tipologiaIntervento"))
                {
                    tipologie.Add(LoadTipologiaIntervento(childElement));
                }

                return tipologie;
            }

            private TipologiaIntervento LoadTipologiaIntervento(XmlElement tipologiaElement)
            {
                TipologiaIntervento tipologia = null;

                string nome = tipologiaElement.GetAttribute("nome");
                string descrizione = tipologiaElement.GetAttribute("descrizione");
                int durata = int.Parse(tipologiaElement.GetAttribute("durata"));

                tipologia = new TipologiaIntervento(nome, descrizione, durata);

                Dictionary<Specializzazione, int> dictionary = new Dictionary<Specializzazione, int>();

                XmlElement specializzazioniElement = (XmlElement) tipologiaElement.SelectSingleNode("specializzazioni");
                foreach (XmlElement childElement in specializzazioniElement.SelectNodes("specializzazione"))
                {
                    int num = int.Parse(childElement.GetAttribute("num"));

                    int idSpecializzazione = int.Parse(childElement.GetAttribute("id"));

                    Boolean trovata = false;
                    foreach(Specializzazione s in Documento.GetInstance().Specializzazioni)
                        if(s.Id.Equals(idSpecializzazione))
                        {
                            dictionary.Add(s,num);
                            trovata = true;
                        }

                    if(!trovata)
                        throw new ArgumentException();
                }
                tipologia.DictionarySpecializzazioni = dictionary;

                HashSet<SalaOperatoria> sale = new HashSet<SalaOperatoria>();

                XmlElement saleElement = (XmlElement)tipologiaElement.SelectSingleNode("sale");
                foreach (XmlElement childElement in saleElement.SelectNodes("sala"))
                {
                    string codiceSala = childElement.GetAttribute("codice");
                    bool trovata = false;
                    foreach (SalaOperatoria s in Documento.GetInstance().SaleOperatorie)
                        if (s.Codice.Equals(codiceSala))
                        {
                            sale.Add(s);
                            trovata = true;
                            break;
                        }

                    if(!trovata)
                        throw new ArgumentException();
                }

                tipologia.SaleOperatorieUtilizzabili = sale;
                

                return tipologia;
            }

        }

        private class SpecializzazioniDocumentoLoader
        {
            private readonly XmlDocument _xmlDocument;

            public SpecializzazioniDocumentoLoader(string fileName)
            {
                _xmlDocument = new XmlDocument();
                _xmlDocument.Load(fileName);
            }

            public List<Specializzazione> Load()
            {
                List<Specializzazione> specializzazioni = new List<Specializzazione>();
                XmlElement rootElement = (XmlElement)_xmlDocument.SelectSingleNode("Documento/Specializzazioni");
                foreach (XmlElement childElement in rootElement)
                {
                    specializzazioni.Add(LoadSpecializzazione(childElement));
                }

                return specializzazioni;
            }

            private Specializzazione LoadSpecializzazione(XmlElement specializzazioneElement)
            {
                string descrizione = specializzazioneElement.GetAttribute("descrizione");
                return new Specializzazione(descrizione);
            }

        }



    }
}
