using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaPrivata.View.Medico;
using ClinicaPrivata.Model;
using System.Windows.Forms;

namespace ClinicaPrivata.Presenter
{
    class CartellaClinicaSetter
    {
        private static CartellaClinicaSetter _instance = null;

        public static CartellaClinicaSetter GetInstance()
        {
            if (_instance == null)
                _instance = new CartellaClinicaSetter();
            return _instance;
        }

        public void SetInfoCartellaClinica(CartellaClinicaForm cartellaClinicaInfo, Object o)
        {
            Paziente p = (Paziente) o;

            cartellaClinicaInfo.PatologieTextBox.Text = p.CartellaClinica.Patologie;
            cartellaClinicaInfo.AllergieTextBox.Text = p.CartellaClinica.Allergie;
            cartellaClinicaInfo.RhTextBox.Text = p.CartellaClinica.FattoreRh.ToString();
            cartellaClinicaInfo.GruppoSanguignoTextBox.Text = p.CartellaClinica.GruppoSanguigno.ToString();

            foreach(Intervento i in Documento.GetInstance().Interventi)
                if (i.Paziente.Equals(p) && (i.StatoIntervento is StatoInterventoPassato))
                    cartellaClinicaInfo.InterventiComboBox.Items.Add(i);
        }

        public void SetInfoIntervento(CartellaClinicaForm cartellaClinicaInfo, Object o)
        {
            Intervento i = (Intervento) o;

            cartellaClinicaInfo.DataTextBox.Text = i.Data.ToString(); ;
            cartellaClinicaInfo.TipologiaTextBox.Text = i.Tipologia.ToString();
            cartellaClinicaInfo.EsitoTextBox.Text = ((StatoInterventoPassato)i.StatoIntervento).Esito;
            cartellaClinicaInfo.NoteTextBox.Text = ((StatoInterventoPassato)i.StatoIntervento).Note;
        }

    }
}
