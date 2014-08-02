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
    class CalendarioMedicoHelper : InterventiHelper
    {
        private Documento _doc = Documento.GetInstance();

        public int SetAll(Control control)
        {
            int result = 0;
            Medico medico = (Medico)Controller.GetInstance().DipendenteLoggato;

            DataGridView grid = (DataGridView)control;

            grid.Columns.RemoveAt(0);

            DataGridViewTextBoxColumn titolo = new DataGridViewTextBoxColumn();
            titolo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            titolo.HeaderText = "Interventi";
            titolo.Name = "Interventi";
            grid.Columns.AddRange(new DataGridViewColumn[] { titolo });

            //Calendario
            ICalendario calendario = new Calendario();
            DateTime dataInizio = Controller.GetInstance().DataInizioRicerca;
            DateTime dataFine = Controller.GetInstance().DataFineRicerca;
            calendario.FiltroInterventi = FiltroBuilder.Build(medico, null, dataInizio, dataFine.AddHours(24));

            foreach (Intervento i in calendario.GetInterventi())
            {
                grid.Rows.Add(i);
                result++;
            }

            return result;
        }

        

    }
}

