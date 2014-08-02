using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClinicaPrivata.Model;
using System.Windows.Forms;
using ClinicaPrivata.View;

namespace ClinicaPrivata.Presenter
{
    class TipologieInterventoHelper : IViewHelper
    {
        private Documento _doc = Documento.GetInstance();

        public int SetAll(Control control)
        {
            int result = 0;
            List<TipologiaIntervento> tipologie = _doc.TipologieIntervento;

            DataGridView grid = (DataGridView)control;

            grid.Columns.RemoveAt(0);

            DataGridViewTextBoxColumn titolo = new DataGridViewTextBoxColumn();
            titolo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            titolo.HeaderText = "Tipologie Intervento";
            titolo.Name = "TipologieIntervento";
            grid.Columns.AddRange(new DataGridViewColumn[] { titolo });

            foreach (TipologiaIntervento t in tipologie)
            {
                grid.Rows.Add(t);
                result++;
            }

            

            return result;
        }

    }
}
