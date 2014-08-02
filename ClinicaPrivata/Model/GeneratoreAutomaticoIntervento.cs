using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClinicaPrivata.Model
{
    class GeneratoreAutomaticoIntervento
    {
        private Documento _doc = Documento.GetInstance();

        public Intervento GeneraIntervento(Paziente paziente, TipologiaIntervento tipologiaIntervento, DateTime startDate)
        {
            Dictionary<Specializzazione, int> specializzazioniRichieste = tipologiaIntervento.DictionarySpecializzazioni;

            Dictionary<Specializzazione, List<Medico>> medici = new Dictionary<Specializzazione, List<Medico>>();
            if (startDate < DateTime.Now.Date)
                return null;
            foreach (Specializzazione spec in specializzazioniRichieste.Keys)
            {
                int mediciRichiesti;
                specializzazioniRichieste.TryGetValue(spec, out mediciRichiesti);

                int mediciDisp = 0;

                medici.Add(spec, new List<Medico>());

                foreach(Medico m in _doc.Medici)
                    if(m.Specializzazione.Equals(spec))
                    {
                        List<Medico> list;
                        medici.TryGetValue(spec, out list);

                        list.Add(m);
                        mediciDisp++;
                    }

                if (mediciDisp < mediciRichiesti)
                    return null;
            }

            foreach (Specializzazione s in medici.Keys)
            {
                List<Medico> list;
                medici.TryGetValue(s, out list);
            }

            List<SalaOperatoria> saleUtilizzabili = new List<SalaOperatoria>();
            foreach (SalaOperatoria s in _doc.SaleOperatorie)
            {
                if (tipologiaIntervento.SaleOperatorieUtilizzabili.Contains(s))
                {
                    saleUtilizzabili.Add(s);
                }
            }
            if (saleUtilizzabili.Count == 0)
                return null;

            return prenota(paziente, tipologiaIntervento, startDate, specializzazioniRichieste, saleUtilizzabili, medici);
        }


        private Intervento prenota(Paziente paziente, TipologiaIntervento tipologiaIntervento, DateTime startDate, Dictionary<Specializzazione, int> specializzazioniRichieste, List<SalaOperatoria> saleUtilizzabili, Dictionary<Specializzazione, List<Medico>> medici)
        {
            DateTime currentDate = startDate;

            int durataIntervento = tipologiaIntervento.Durata;

            if ((currentDate.Hour>=9)&&(currentDate.Hour<=17)&&(currentDate.AddHours(durataIntervento).Hour>=9)&&(currentDate.AddHours(durataIntervento).Hour<=17)
                &&(!currentDate.DayOfWeek.Equals(DayOfWeek.Saturday))&&(!currentDate.DayOfWeek.Equals(DayOfWeek.Sunday)))
            {
                foreach (SalaOperatoria sala in saleUtilizzabili)
                {
                    if (isSalaFree(sala, currentDate, tipologiaIntervento.Durata))
                    {
                        //per ogni specializzazione i medici liberi
                        Dictionary<Specializzazione, List<Medico>> mediciLiberi = new Dictionary<Specializzazione, List<Medico>>();
                        foreach (Specializzazione specializzazione in medici.Keys)
                        {
                            mediciLiberi.Add(specializzazione, new List<Medico>());

                            List<Medico> mediciSpec;
                            medici.TryGetValue(specializzazione, out mediciSpec);
                            foreach (Medico medicoSpec in mediciSpec)
                            {
                                if (isMedicoFree(medicoSpec, currentDate, durataIntervento))
                                {
                                    List<Medico> l;
                                    mediciLiberi.TryGetValue(specializzazione, out l);
                                    l.Add(medicoSpec);
                                }
                            }
                        }

                        foreach (Specializzazione s in specializzazioniRichieste.Keys)
                        {
                            List<Medico> l;
                            mediciLiberi.TryGetValue(s, out l);

                            int numMediciSpecRichiesti;
                            specializzazioniRichieste.TryGetValue(s, out numMediciSpecRichiesti);

                            if(l.Count < numMediciSpecRichiesti)
                                return prenota(paziente, tipologiaIntervento, currentDate.AddHours(1), specializzazioniRichieste, saleUtilizzabili, medici);
                        }

                        //sala libera, medici con spec ok liberi e loro numero ok
                        List<Medico> equipe = new List<Medico>();
                        foreach (Specializzazione s in specializzazioniRichieste.Keys)
                        {
                            int numRichiesto;
                            specializzazioniRichieste.TryGetValue(s, out numRichiesto);

                            int count = 0;
                            List<Medico> mediciList;
                            mediciLiberi.TryGetValue(s, out mediciList);

                            foreach (Medico m in mediciList)
                            {
                                equipe.Add(m);
                                count++;

                                if (count == numRichiesto)
                                    break;
                            }
                        }

                        Intervento i = new Intervento(paziente,tipologiaIntervento,sala,equipe,currentDate);

                        return i;
                    }
                }
            }
            return prenota(paziente, tipologiaIntervento, currentDate.AddHours(1), specializzazioniRichieste, saleUtilizzabili, medici);

        }


        #region sala libera?

        //verifica se in un orario la sala è libera
        private Boolean isSalaFree(SalaOperatoria s, DateTime date, int durata)
        {
            foreach (Intervento i in _doc.Interventi)
            {
                if(i.SalaOperatoria.Equals(s))
                {
                    DateTime inizioIntervento = i.Data;
                    DateTime temp = inizioIntervento;
                    DateTime fineIntervento = temp.AddHours(i.Tipologia.Durata);

                    DateTime inizio = date;
                    DateTime fine = date.AddHours(durata);
                    if (!((inizio < inizioIntervento && fine <= inizioIntervento) ||  (inizio >= fineIntervento && fine > fineIntervento)))
                        return false;
                }
            }

            return true;
        }

        #endregion

        #region medico libero?

        //verifica se in un orario il medico è libero
        private Boolean isMedicoFree(Medico medico, DateTime date, int durata)
        {
            foreach (Intervento i in _doc.Interventi)
            {
                foreach (Medico m in i.Equipe)
                {
                    if (medico.Equals(m))
                    {
                        DateTime inizioIntervento = i.Data;
                        DateTime temp = inizioIntervento;
                        DateTime fineIntervento = temp.AddHours(i.Tipologia.Durata);

                        DateTime inizio = date;
                        DateTime fine = date.AddHours(durata);
                        if (!((inizio < inizioIntervento && fine <= inizioIntervento) || (inizio >= fineIntervento && fine > fineIntervento)))
                            return false;
                    }
                }
            }

            return true;
        }

        #endregion
    }
}
