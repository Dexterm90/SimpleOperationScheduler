using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaPrivata.Model;

namespace ClinicaPrivata.Presenter
{
    class PrenotaInterventi
    {
        public void prenotaIntervento(Object p, Object t, DateTime date, Label resultLabel)
        {
            date = date.Date;

            GeneratoreAutomaticoIntervento gen = new GeneratoreAutomaticoIntervento();
            Intervento nuovoIntervento = gen.GeneraIntervento((Paziente)p, (TipologiaIntervento)t, date);
            resultLabel.AutoSize = true;
            if (nuovoIntervento != null)
            {
                Documento.GetInstance().Add(nuovoIntervento);
                resultLabel.Text = "Prenotato intervento in data " + nuovoIntervento.Data.Day + "/" + nuovoIntervento.Data.Month + "/" + nuovoIntervento.Data.Year + " alle ore " + nuovoIntervento.Data.Hour;
            }
            else
                resultLabel.Text = "Impossibile prenotare l'intervento";
            Console.WriteLine(nuovoIntervento);
        }

        public void setPazienti(ComboBox comboBox)
        {
            foreach (Paziente p in Documento.GetInstance().Pazienti)
                comboBox.Items.Add(p);
        }

        public void setTipologia(ComboBox comboBox)
        {
            foreach (TipologiaIntervento t in Documento.GetInstance().TipologieIntervento)
                comboBox.Items.Add(t);
        }
    }
}
