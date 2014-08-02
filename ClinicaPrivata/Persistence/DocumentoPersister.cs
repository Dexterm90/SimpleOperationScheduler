using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Globalization;

using ClinicaPrivata.Model;

namespace ClinicaPrivata.Persistence
{
    class DocumentoPersister : IDocumentoPersister
    {
        private readonly string _filePazienti, _fileDipendenti, _fileInterventi, _fileSaleOperatorie, _fileTipologie, _fileSpecializzazioni;

        public DocumentoPersister(string filePazienti, string fileDipendenti, string fileInterventi, string fileSaleOperatorie, string fileTipologie, string fileSpecializzazioni)
        {
            _filePazienti = filePazienti;
            _fileDipendenti = fileDipendenti;
            _fileInterventi = fileInterventi;
            _fileSaleOperatorie = fileSaleOperatorie;
            _fileTipologie = fileTipologie;
            _fileSpecializzazioni = fileSpecializzazioni;

        }

        #region IDocumentoPersister Members

        public IDocumentoLoader GetLoader()
        {
            return new DocumentoLoader(_filePazienti, _fileDipendenti, _fileInterventi, _fileSaleOperatorie, _fileTipologie, _fileSpecializzazioni);
        }

        public void Save(Documento documento)
        {
            DocumentoSaver saver = new DocumentoSaver(_filePazienti, _fileDipendenti, _fileInterventi, _fileSaleOperatorie, _fileTipologie, _fileSpecializzazioni);
            saver.Save(documento);
        }

        #endregion


        private class DocumentoSaver
        {
            private readonly XmlWriter _writerPazienti, _writerDipendenti, _writerInterventi, _writerSaleOperatorie, _writerTipologieIntervento, _writerSpecializzazioni;

            public DocumentoSaver(string filePazienti, string fileDipendenti, string fileInterventi, string fileSaleOperatorie, string fileTipologieIntervento, string fileSpecializzazioni)
            {
                _writerPazienti = XmlWriter.Create(filePazienti, new XmlWriterSettings() { Indent = true });
                _writerDipendenti = XmlWriter.Create(fileDipendenti, new XmlWriterSettings() { Indent = true });
                _writerInterventi = XmlWriter.Create(fileInterventi, new XmlWriterSettings() { Indent = true });
                _writerSaleOperatorie = XmlWriter.Create(fileSaleOperatorie, new XmlWriterSettings() { Indent = true });
                _writerTipologieIntervento = XmlWriter.Create(fileTipologieIntervento, new XmlWriterSettings() { Indent = true });
                _writerSpecializzazioni = XmlWriter.Create(fileSpecializzazioni, new XmlWriterSettings() { Indent = true });
            }

            public void Save(Documento documento)
            {
                SavePazienti(documento.Pazienti);
                SaveDipendenti(documento.Dipendenti);
                SaveInterventi(documento.Interventi);
                SaveSaleOperatorie(documento.SaleOperatorie);
                SaveTipologieIntervento(documento.TipologieIntervento);
                SaveSpecializzazioni(documento.Specializzazioni);
            }

            private void SavePazienti(IEnumerable<Paziente> pazienti)
            {
                _writerPazienti.WriteStartDocument();
                _writerPazienti.WriteStartElement("Documento");
                _writerPazienti.WriteStartElement("Pazienti");
                Console.WriteLine("<Pazienti>");
                foreach (Paziente paziente in pazienti)
                {
                    SavePaziente(paziente);
                }
                _writerPazienti.WriteEndElement(); //Pazienti
                Console.WriteLine("</Pazienti>");
                _writerPazienti.WriteEndElement();
                _writerPazienti.WriteEndDocument();
                _writerPazienti.Close();
            }

            private void SavePaziente(Paziente paziente)
            {
                _writerPazienti.WriteStartElement("Paziente");
                _writerPazienti.WriteAttributeString("nome", paziente.Nome);
                _writerPazienti.WriteAttributeString("cognome", paziente.Cognome);
                _writerPazienti.WriteAttributeString("cf", paziente.CodiceFiscale);
                _writerPazienti.WriteAttributeString("luogoDiNascita", paziente.LuogoNascita);
                _writerPazienti.WriteAttributeString("dataDiNascita", paziente.DataNascita.ToString("dd/MM/yy", DateTimeFormatInfo.InvariantInfo));
                _writerPazienti.WriteAttributeString("telefono", paziente.Telefono);
                _writerPazienti.WriteStartElement("Indirizzo");
                _writerPazienti.WriteAttributeString("via", paziente.Indirizzo.Via);
                _writerPazienti.WriteAttributeString("numeroCivico", paziente.Indirizzo.NumeroCivico);
                _writerPazienti.WriteAttributeString("località", paziente.Indirizzo.Località);
                _writerPazienti.WriteAttributeString("cap", paziente.Indirizzo.Cap.ToString());
                _writerPazienti.WriteAttributeString("provincia", paziente.Indirizzo.Provincia);
                _writerPazienti.WriteAttributeString("nazione", paziente.Indirizzo.Nazione);
                _writerPazienti.WriteEndElement(); //Indirizzo
                _writerPazienti.WriteStartElement("CartellaClinica");
                _writerPazienti.WriteAttributeString("patologie", paziente.CartellaClinica.Patologie);
                _writerPazienti.WriteAttributeString("allergie", paziente.CartellaClinica.Allergie);
                _writerPazienti.WriteAttributeString("fattoreRh", ((int)paziente.CartellaClinica.FattoreRh).ToString());
                _writerPazienti.WriteAttributeString("gruppoSanguigno", ((int)paziente.CartellaClinica.GruppoSanguigno).ToString());
                _writerPazienti.WriteEndElement(); //CartellaClinica
                _writerPazienti.WriteEndElement(); //Paziente
            }

            private void SaveDipendenti(IEnumerable<Dipendente> dipendenti)
            {
                _writerDipendenti.WriteStartDocument();
                _writerDipendenti.WriteStartElement("Documento");
                _writerDipendenti.WriteStartElement("Dipendenti");
                foreach (Dipendente dipendente in dipendenti)
                {
                    SaveDipendente(dipendente);
                }
                _writerDipendenti.WriteEndElement(); //Dipendenti
                _writerDipendenti.WriteEndElement();
                _writerDipendenti.WriteEndDocument();
                _writerDipendenti.Close();
            }

            private void SaveDipendente(Dipendente dipendente)
            {
                _writerDipendenti.WriteStartElement(dipendente.GetType().Name);
                _writerDipendenti.WriteAttributeString("nome", dipendente.Nome);
                _writerDipendenti.WriteAttributeString("cognome", dipendente.Cognome);
                _writerDipendenti.WriteAttributeString("cf", dipendente.CodiceFiscale);
                _writerDipendenti.WriteAttributeString("username", dipendente.Username);
                _writerDipendenti.WriteAttributeString("password", dipendente.Password);
                if (dipendente is Medico)
                {
                    Medico medico = (Medico)dipendente;
                    _writerDipendenti.WriteAttributeString("codiceOrdineMedici", medico.CodiceOrdineMedici);
                    _writerDipendenti.WriteAttributeString("specializzazione", medico.Specializzazione.ToString());
                }
                _writerDipendenti.WriteEndElement(); // Dipendente (Medico|Segretario|Amministratore)
            }

            private void SaveInterventi(IEnumerable<Intervento> interventi)
            {
                _writerInterventi.WriteStartDocument();
                _writerInterventi.WriteStartElement("Documento");
                _writerInterventi.WriteStartElement("Interventi");
                foreach (Intervento intervento in interventi)
                {
                    SaveIntervento(intervento);
                }
                _writerInterventi.WriteEndElement();//Interventi
                _writerInterventi.WriteEndElement();
                _writerInterventi.WriteEndDocument();
                _writerInterventi.Close();
            }

            private void SaveIntervento(Intervento intervento)
            {
                _writerInterventi.WriteStartElement("intervento");
                _writerInterventi.WriteAttributeString("data", intervento.Data.ToString("dd/MM/yy", DateTimeFormatInfo.InvariantInfo));
                _writerInterventi.WriteAttributeString("oraDiInizio", intervento.Data.Hour.ToString());
                _writerInterventi.WriteAttributeString("cfPaziente", intervento.Paziente.CodiceFiscale);
                _writerInterventi.WriteAttributeString("idTipologiaIntervento", intervento.Tipologia.Id.ToString());
                _writerInterventi.WriteAttributeString("codiceSalaOperatoria", intervento.SalaOperatoria.Codice);
                if (intervento.StatoIntervento is StatoInterventoPassato)
                {
                    _writerInterventi.WriteAttributeString("esito", ((StatoInterventoPassato)intervento.StatoIntervento).Esito);
                    _writerInterventi.WriteAttributeString("note", ((StatoInterventoPassato)intervento.StatoIntervento).Note);
                }
                foreach (Medico medico in intervento.Equipe)
                {
                    _writerInterventi.WriteStartElement("medico");
                    _writerInterventi.WriteAttributeString("codiceOrdineMedici", medico.CodiceOrdineMedici.ToString());
                    _writerInterventi.WriteEndElement(); //medico
                }
                _writerInterventi.WriteEndElement(); //intervento
            }

            private void SaveSaleOperatorie(IEnumerable<SalaOperatoria> saleOperatorie)
            {
                _writerSaleOperatorie.WriteStartDocument();
                _writerSaleOperatorie.WriteStartElement("Documento");
                _writerSaleOperatorie.WriteStartElement("SaleOperatorie");
                foreach (SalaOperatoria salaOperatoria in saleOperatorie)
                {
                    SaveSalaOperatoria(salaOperatoria);
                }
                _writerSaleOperatorie.WriteEndElement(); // SaleOperatorie
                _writerSaleOperatorie.WriteEndElement();
                _writerSaleOperatorie.WriteEndDocument();
                _writerSaleOperatorie.Close();
            }

            private void SaveSalaOperatoria(SalaOperatoria salaOperatoria)
            {
                _writerSaleOperatorie.WriteStartElement("SalaOperatoria");
                _writerSaleOperatorie.WriteAttributeString("codice", salaOperatoria.Codice);
                _writerSaleOperatorie.WriteEndElement(); //SalaOperatoria
            }

            private void SaveTipologieIntervento(IEnumerable<TipologiaIntervento> tipologieIntervento)
            {
                _writerTipologieIntervento.WriteStartDocument();
                _writerTipologieIntervento.WriteStartElement("Documento");
                _writerTipologieIntervento.WriteStartElement("TipologieIntervento");
                foreach (TipologiaIntervento tipologiaIntervento in tipologieIntervento)
                {
                    SaveTipologiaIntervento(tipologiaIntervento);
                }
                _writerTipologieIntervento.WriteEndElement(); //TipologieIntervento
                _writerTipologieIntervento.WriteEndElement();
                _writerTipologieIntervento.WriteEndDocument();
                _writerTipologieIntervento.Close();
            }

            private void SaveTipologiaIntervento(TipologiaIntervento tipologiaIntervento)
            {
                _writerTipologieIntervento.WriteStartElement("tipologiaIntervento");
                _writerTipologieIntervento.WriteAttributeString("nome", tipologiaIntervento.Nome);
                _writerTipologieIntervento.WriteAttributeString("descrizione", tipologiaIntervento.Descrizione);
                _writerTipologieIntervento.WriteAttributeString("durata", tipologiaIntervento.Durata.ToString());
                _writerTipologieIntervento.WriteStartElement("specializzazioni");
                foreach (Specializzazione s in tipologiaIntervento.DictionarySpecializzazioni.Keys)
                {
                    _writerTipologieIntervento.WriteStartElement("specializzazione");
                    _writerTipologieIntervento.WriteAttributeString("id", s.Id.ToString());
                    int num;
                    tipologiaIntervento.DictionarySpecializzazioni.TryGetValue(s, out num);
                    _writerTipologieIntervento.WriteAttributeString("num", num.ToString());

                    _writerTipologieIntervento.WriteEndElement(); //specializzazione
                }
                _writerTipologieIntervento.WriteEndElement(); //specializzazioni
                _writerTipologieIntervento.WriteStartElement("sale");
                foreach (SalaOperatoria salaOperatoria in tipologiaIntervento.SaleOperatorieUtilizzabili)
                {
                    _writerTipologieIntervento.WriteStartElement("sala");
                    _writerTipologieIntervento.WriteAttributeString("codice", salaOperatoria.Codice);
                    _writerTipologieIntervento.WriteEndElement(); //sala
                }
                _writerTipologieIntervento.WriteEndElement(); //sale
                _writerTipologieIntervento.WriteEndElement(); //tipologiaIntervento
            }

            private void SaveSpecializzazioni(IEnumerable<Specializzazione> specializzazioni)
            {
                _writerSpecializzazioni.WriteStartDocument();
                _writerSpecializzazioni.WriteStartElement("Documento");
                _writerSpecializzazioni.WriteStartElement("Specializzazioni");
                foreach (Specializzazione specializzazione in specializzazioni)
                {
                    SaveSpecializzazione(specializzazione);
                }
                _writerSpecializzazioni.WriteEndElement(); //Specializzazioni
                _writerSpecializzazioni.WriteEndElement();
                _writerSpecializzazioni.WriteEndDocument();
                _writerSpecializzazioni.Close();
            }

            private void SaveSpecializzazione(Specializzazione specializzazione)
            {
                _writerSpecializzazioni.WriteStartElement("specializzazione");
                _writerSpecializzazioni.WriteAttributeString("descrizione", specializzazione.Descrizione);
                _writerSpecializzazioni.WriteEndElement(); //specializzazione
            }
        }
    }
}
