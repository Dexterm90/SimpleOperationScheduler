using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClinicaPrivata.Model;

namespace ClinicaPrivata.Presenter
{
    class SegretariHelper : IViewHelper
    {
        private Documento _doc = Documento.GetInstance();

        public int SetAll(Control control)
        {
            int result = 0;
            List<Segretario> segretari = _doc.Segretari;

            DataGridView grid = (DataGridView)control;

            grid.Columns.RemoveAt(0);

            DataGridViewTextBoxColumn titolo = new DataGridViewTextBoxColumn();
            titolo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            titolo.HeaderText = "Segretari";
            titolo.Name = "Segretari";
            grid.Columns.AddRange(new DataGridViewColumn[] { titolo });

            foreach (Segretario s in segretari)
            {
                grid.Rows.Add(s);
                result++;
            }

            return result;
        }

    }
}
