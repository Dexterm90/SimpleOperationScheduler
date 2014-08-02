using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaPrivata.Model;
using System.Windows.Forms;
using ClinicaPrivata.View;
using ClinicaPrivata.View.Medico;

namespace ClinicaPrivata.Presenter
{
    class PazientiHelper : IViewHelper
    {
        private Documento _doc = Documento.GetInstance();

        //il valore di ritorno indica il numero di pazienti agggiunti al controllo
        //aggiunge tutti i pazienti ad una griglia
        public int SetAll(Control control)
        {
            int result = 0;
            List<Paziente> pazienti = _doc.Pazienti;

            DataGridView grid = (DataGridView) control;


            grid.Columns.RemoveAt(0);

            DataGridViewTextBoxColumn titolo = new DataGridViewTextBoxColumn();
            titolo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            titolo.HeaderText = "Pazienti";
            titolo.Name = "Pazienti";
            grid.Columns.AddRange(new DataGridViewColumn[] { titolo });

            foreach (Paziente p in pazienti)
            {
                grid.Rows.Add(p);
                result++;
            }



            return result;
        }

        public void SetInfoPaziente(InfoPazienteForm infoPaziente, Object o)
        {
            Paziente p = (Paziente) o;

            infoPaziente.NomeTextBox.Text = p.Nome;
            infoPaziente.CognomeTextBox.Text = p.Cognome;
            infoPaziente.CfTextBox.Text = p.CodiceFiscale;
            infoPaziente.LuogoDiNascitaTextBox.Text = p.LuogoNascita;
            infoPaziente.DataDiNascitaTextBox.Text = p.DataNascita.ToString();
            infoPaziente.TelefonoTextBox.Text = p.Telefono;

            //indirizzo
            infoPaziente.ViaTextBox.Text = p.Indirizzo.Via;
            infoPaziente.NumeroCivicoTextBox.Text = p.Indirizzo.NumeroCivico;
            infoPaziente.LocalitàTextBox.Text = p.Indirizzo.Località;
            infoPaziente.CapTextBox.Text = p.Indirizzo.Cap.ToString();
            infoPaziente.ProvinciaTextBox.Text = p.Indirizzo.Provincia;
            infoPaziente.NazioneTextBox.Text = p.Indirizzo.Nazione;
        }

        private List<Intervento> GetInterventiMedico()
        {
            List<Intervento> res = new List<Intervento>();

            Medico medico = (Medico)Controller.GetInstance().DipendenteLoggato;

            foreach (Intervento i in Documento.GetInstance().Interventi)
                if (i.Equipe.Contains(medico))
                    res.Add(i);

            return res;
        }

        public void SalvaEsitoNote(String esito, String note, Object o)
        {
            Intervento i = (Intervento) o;

            ((StatoInterventoPassato)i.StatoIntervento).Esito = esito;
            ((StatoInterventoPassato)i.StatoIntervento).Note = note;
        }
    }
}
