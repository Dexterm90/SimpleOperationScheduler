using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaPrivata.Model;
using ClinicaPrivata.View;
using System.Reflection;

namespace ClinicaPrivata.Presenter
{
    class InterventiHelper : IViewHelper
    {
        private Documento _doc = Documento.GetInstance();

        public int SetAll(Control control)
        {
            int result = 0;
            List<Intervento> interventi = _doc.Interventi;

            DataGridView grid = (DataGridView)control;

            foreach (Intervento i in interventi)
            {
                grid.Rows.Add(i);
                result++;
            }

            return result;
        }

        public int SetAllFuturi(Control control)
        {
            int result = 0;
            List<Intervento> interventi = _doc.Interventi;

            DataGridView grid = (DataGridView)control;

            foreach (Intervento i in interventi)
            {
                if (i.StatoIntervento is StatoInterventoFuturo)
                {
                    grid.Rows.Add(i);
                    result++;
                }
            }

            return result;
        }

        public int SetAllMedicoPassati(Control control)
        {
            Medico medico = (Medico)Controller.GetInstance().DipendenteLoggato;

            int result = 0;
            List<Intervento> interventi = _doc.Interventi;

            DataGridView grid = (DataGridView)control;

            foreach (Intervento i in interventi)
            {
                if (i.StatoIntervento is StatoInterventoPassato && i.Equipe.Contains(medico))
                {
                    grid.Rows.Add(i);
                    result++;
                }
            }

            return result;
        }


        public void displayInterventoInfo(InterventiForm interventiForm , Object o)
        {
            interventiForm.StatoInterventoGroupBox.Visible = false;

            Intervento i = (Intervento) o;

            interventiForm.DataTextBox.Text = i.Data.ToString();
            interventiForm.SalaOperatoriaTextBox.Text = i.SalaOperatoria.ToString();
            interventiForm.NomeTextBox.Text = i.Paziente.Nome;
            interventiForm.CognomeTextBox.Text = i.Paziente.Cognome;
            interventiForm.DescrizioneTipologiaTextBox.Text = i.Tipologia.Descrizione;
            interventiForm.DurataTipologiaTextBox.Text = i.Tipologia.Durata.ToString();

            if (i.StatoIntervento is StatoInterventoPassato)
            {
                interventiForm.StatoInterventoGroupBox.Visible = true;
                interventiForm.EsitoTextBox.Text = ((StatoInterventoPassato)i.StatoIntervento).Esito;
                interventiForm.NoteTextBox.Text = ((StatoInterventoPassato)i.StatoIntervento).Note;
            }
        }
    }  
}
